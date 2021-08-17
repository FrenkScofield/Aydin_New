using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Text.RegularExpressions;

namespace CMSSite.Controllers
{
    public class BaseController : Controller
    {
        IHttpContextAccessor _httpContextAccessor;
        IHostingEnvironment _IHostingEnvironment;
        IContentPageService _IContentPageService;
        IDocumentsService _IDocumentsService;
        ISiteConfigService _ISiteConfigService;
        IUserService _IUserService;
        IFormsService _IFormsService;
        ISendMail _ISendMailService;

        public BaseController(

            IHostingEnvironment _IHostingEnvironment,
          IContentPageService _IContentPageService,
        IDocumentsService _IDocumentsService,
        ISiteConfigService _ISiteConfigService,
        IHttpContextAccessor _httpContextAccessor,
         IUserService _IUserService,
          IFormsService _IFormsService,
            ISendMail _ISendMailService
            )
        {

            this._IHostingEnvironment = _IHostingEnvironment;
            this._ISiteConfigService = _ISiteConfigService;
            this._IDocumentsService = _IDocumentsService;
            this._IContentPageService = _IContentPageService;
            this._httpContextAccessor = _httpContextAccessor;
            this._IUserService = _IUserService;
            this._IFormsService = _IFormsService;
            this._ISendMailService = _ISendMailService;
        }
        public IActionResult BaseContent()
        {
            var link = HttpContext.Items["cmspage"].ToString();
            var config = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("config", config);

            if (!string.IsNullOrEmpty(link))
            {
                var menu = _IContentPageService.Where(o => o.Link.ToLower() == link.ToLower(), true, false, o => o.Documents).Result.FirstOrDefault();
                if (menu != null)
                {

                    ViewBag.content = menu;
                    return View();
                }
                else
                {
                    return Redirect(SessionRequest.config.BaseUrl);
                }
            }
            else
            {
                return Redirect(SessionRequest.config.BaseUrl);
            }
        }

        //[Route("Search/{search?}")]
        public IActionResult Search(string search)
        {
            var langID = _httpContextAccessor.HttpContext.Session.GetInt32("LanguageID");
            if (langID == null)
                langID = 1;

            ViewBag.LanguageID = langID;

            setData();

            var contentPages = _IContentPageService.Where(x =>
            x.Parent != null &&
            x.ContentPageId != null &&

           (x.Name.ToLower().Contains(search.ToLower())
            || x.Description.ToLower().Contains(search.ToLower())
            || x.ContentShort.ToLower().Contains(search.ToLower())
            || x.ContentData.ToLower().Contains(search.ToLower())


            ) &&
            x.LangId == langID && x.IsDeleted == null && x.IsPublish == true , true, false,
                o => o.ContentPageChilds, o => o.SpecContentValue, o => o.Parent, o => o.Gallery, o => o.Documents, o => o.ThumbImage, o => o.Picture, o => o.BannerImage).Result.ToList();

            ViewBag.contents = contentPages;

            return View();
        }
        public IActionResult Index()
        {
            var data = _IContentPageService.Where().Result.ToList();
            setData();
            return View();
        }
 
        public IActionResult HtmlRaw()
        {
            setData();
            return View();
        }
        public IActionResult Content()
        {
            var link = HttpContext.Items["cmspage"].ToString();
            var config = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("config", config);
            if (!string.IsNullOrEmpty(link))
            {
                var menu = _IContentPageService.Where(o => o.Link == link, true, false, o => o.Documents, o => o.TemplateType).Result.FirstOrDefault();
                if (menu != null)
                {
                    ViewBag.page = menu;
                    return View();
                }
                else
                {
                    return Redirect(SessionRequest.config.BaseUrl);
                }
            }
            else
            {
                return Redirect(SessionRequest.config.BaseUrl);
            }
        }
        public IActionResult SideContent(string link)
        {
            getPageData(link);
            return View();
        }
        private List<ContentPage> getPageData(string link)
        {
            var fullLink = HttpContext.Request.Path.Value.Trim().ToStr();
            var contentPages = _IContentPageService.Where(null, true, false).Result.ToList();

            ViewBag.contentPages = contentPages.ToList();
            ViewBag.Pages = contentPages.ToList();
            var config = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("config", config);
            if (!string.IsNullOrEmpty(link))
            {
                var menu = _IContentPageService.Where(o => o.Link == link, true, false).Result.FirstOrDefault();
                if (menu != null)
                {
                    ViewBag.page = menu;
                }
                else
                {
                    Redirect(SessionRequest.config.BaseUrl);
                }
            }
            else
            {
                Redirect(SessionRequest.config.BaseUrl);
            }


            return contentPages;
        }
     
        [HttpPost]
        public JsonResult FormSave(string email, string name,string phone, string message,string subject,string check,string check2, string comment)
        {
            if (!string.IsNullOrEmpty(check) && check == "1" && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(email))
            {
                // mF.Email = postModel["Email"];
                Forms myForm = new Forms();
                myForm.Email = email;
                myForm.Name = name;
                myForm.Phone = phone;
                myForm.Message = message; 
                myForm.Subject = subject;
                myForm.FormTypeId = 1;
                myForm.CreaUser = 1;
                //var result = _IFormsService.InsertOrUpdate(myForm); 

                var config = _ISiteConfigService.Where(null, true, false, null).Result.FirstOrDefault();

                config.Mail = config.Mail;
                config.SmtpMail = config.SmtpMail;
                config.SmtpMailPass = config.SmtpMailPass;
                config.SmtpHost = config.SmtpHost;
                config.SmtpPort = config.SmtpPort;
                config.MailGorunenAd = config.MailGorunenAd;
                config.SmtpSSL = true;

                string[] ccListStr = null;
                //  if (string.IsNullOrEmpty(result.ResultRow.FormType.MailCC))
                //  {
                //      ccListStr = null;
                //  }
                //  else
                //  {
                //      ccListStr = result.ResultRow.FormType.MailCC.Split(',');
                //
                //  }


                var mailStr = "<!DOCTYPE html><html><head><style>th, td {  border: 1px solid #eee;}table{max-width:800px;}td{color:#000;}</style></head><body>";

                mailStr += "<table  width'100%'>";
                mailStr += "<tr><td>Ad Soyad : "+ myForm.Name + "</td></tr>";
                mailStr += "<tr><td>E-Posta : " + myForm.Email + "</td></tr>";
                mailStr += "<tr><td>Telefon : " + myForm.Phone + "</td></tr>";
                mailStr += "<tr><td>Konu : " + myForm.Subject + "</td></tr>";
                mailStr += "<tr><td>Mesaj : " + myForm.Message + "</td></tr>";
                mailStr += "</table></body></html>";

        string mailResult = _ISendMailService.Send(new MailModelCustom { Alicilar = new string[] { config.Mail }, cc = ccListStr, Icerik = mailStr, Konu = "Aydın Holding Website - İletişim Formu", MailGorunenAd = config.MailGorunenAd, SmtpHost = config.SmtpHost, SmtpMail = config.SmtpMail, SmtpMailPass = config.SmtpMailPass, SmtpPort = config.SmtpPort, SmtpSSL = config.SmtpSSL, SmtpUseDefaultCredentials = false });

                return Json("OK");
            }
            else
            {
                return Json("NO");
            }
        }

        public IActionResult Header()
        {
            #region dynamicContent

            var contentPages = _IContentPageService.Where(null, true, false, o => o.ContentPageChilds, o => o.Documents).Result.ToList();
            contentPages.ForEach(o =>
            {
                o.ContentPageChilds = contentPages.Where(oo => oo.ContentPageId == o.Id).ToList();
            });
            ViewBag.contentPages = contentPages;
            //   ViewBag.fikirler = _IFikirService.Where(o => o.FikirStatus != FikirDurumu.Ondegerlendirme,
            //      true, false,
            //      o => o.AtananDepartman, o => o.AtananKullanici, o => o.FikirBegen).Result.ToList();
            var config = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("config", config);

            var _user = _IUserService.Where(o => (o.Name == "admin"), true, false).Result.FirstOrDefault();

            _httpContextAccessor.HttpContext.Session.Set("_user", _user);
            ViewBag.Portals = contentPages.Where(x => x.ContentPageId == 136).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();
            #endregion
            return View();
        }
        public IActionResult Footer()
        {
            return View();
        }
        public void setData()
        {
            #region dynamicContent
            var link = HttpContext.Request.Path.Value.Trim().ToStr();
            List<ContentPage> contentPages = new List<ContentPage>();
            contentPages = _IContentPageService.Where(x => x.IsPublish == true && x.IsActive == true, true, false, o => o.ContentPageChilds, o => o.Parent, o => o.Gallery, o => o.Documents, o => o.ThumbImage, o => o.Picture, o => o.BannerImage).Result.ToList();
            _httpContextAccessor.HttpContext.Session.Set("contentPages", contentPages);



            ViewBag.MetaTitle = "Turgut Aydın Holding";
            ViewBag.MetaDescription = "Turgut Aydın Holding";

            ViewBag.Portals = contentPages.Where(x => x.ContentPageId == 136).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();

            //if (_httpContextAccessor.HttpContext.Session.Get("contentPages") == null)
            //{
            //    contentPages = _IContentPageService.Where(null, true, false, o => o.ContentPageChilds, o => o.Parent, o => o.Gallery, o => o.Documents, o => o.ThumbImage, o => o.Image, o => o.BannerImage).Result.ToList();
            //    _httpContextAccessor.HttpContext.Session.Set("contentPages", contentPages);
            //}
            //else
            //{
            //    contentPages =
            //    _httpContextAccessor.HttpContext.Session.Get<List<ContentPage>>("contentPages");
            //    _httpContextAccessor.HttpContext.Session.Set("contentPages", contentPages);
            //}
            ViewBag.IsHeaderMenu = contentPages.Where(o => o.IsHeaderMenu == true).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();
            ViewBag.IsFooterMenu = contentPages.Where(o => o.IsFooterMenu == true).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();
            ViewBag.contentPages = contentPages.ToList();
            ViewBag.Pages = contentPages;
       
            //   ViewBag.fikirler = _IFikirService.Where(o => o.FikirStatus != FikirDurumu.Ondegerlendirme,
            //      true, false,
            //      o => o.AtananDepartman, o => o.AtananKullanici, o => o.FikirBegen).Result.ToList();
            var config = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("config", config);
            var _user = _IUserService.Where(o => (o.Name == "admin"), true, false).Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("_user", _user);
            #endregion
        }
        public IActionResult GetTemplateType()
        {
            var list = Enum.GetValues(typeof(TemplateType)).Cast<int>().Select(x => new { value = x.ToString(), text = ((TemplateType)x).ExGetDescription() }).ToArray();
            return Json(list);
        }

        [Route("profil")]
        public IActionResult profil()
        {
            return View();
        }



    }
}
//web@cuhadaroglu.com