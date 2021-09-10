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

            //the code of the images that will come on the mobile side. START
            string u = HttpContext.Request.Headers["User-Agent"];
            System.Text.RegularExpressions.Regex b = new System.Text.RegularExpressions.Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Multiline);
            System.Text.RegularExpressions.Regex v = new System.Text.RegularExpressions.Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Multiline);


            if ((b.IsMatch(u) || v.IsMatch(u.Substring(0, 4))))
            {
                ViewBag.isMobile = true;
            }
            else
            {
                ViewBag.isMobile = false;
            }
            //the code of the images that will come on the mobile side. END

            ViewBag.MetaTitle = "Aydın Grup";
            ViewBag.MetaDescription = "Aydın Grup";

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