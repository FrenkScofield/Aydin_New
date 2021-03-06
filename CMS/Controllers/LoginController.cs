using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CMS.Controllers
{
    public class LoginController : Controller
    {
        ISiteConfigService _ISiteConfigService;
        IUserService _IUserService;
        ILangService _ILangService;
        IContentTypesService _IContentTypesService;
        IHttpContextAccessor _httpContextAccessor;
        IHostingEnvironment _IHostingEnvironment;
        IFormTypeService _IFormTypeService;
        public LoginController(
            ISiteConfigService _ISiteConfigService,
         IUserService _IUserService,
         IHttpContextAccessor _IHttpContextAccessor,
         IHostingEnvironment _IHostingEnvironment,
         IContentTypesService _IContentTypesService,
         ILangService _ILangService,
         IFormTypeService _IFormTypeService
            )
        {
            this._ISiteConfigService = _ISiteConfigService;
            this._IUserService = _IUserService;
            this._httpContextAccessor = _IHttpContextAccessor;
            this._IHostingEnvironment = _IHostingEnvironment;
            this._ILangService = _ILangService;
            this._IContentTypesService = _IContentTypesService;
            this._IFormTypeService = _IFormTypeService;
        }


        public IActionResult Login1()
        {
            var siteConfig = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("siteConfig", siteConfig);

            if (_httpContextAccessor.HttpContext.Session.Get("_user") != null)
            {
                return RedirectToAction("Index", "Base");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Validate(string user, string pass)
        {
            var _user = _IUserService.Where(o => (o.UserName == user || o.Name == user) && (o.Pass == pass), true, false).Result.FirstOrDefault();
            if (_user != null)
            {
                _user.LoginCount = _user.LoginCount == null ? null : _user.LoginCount++;
                _httpContextAccessor.HttpContext.Session.Set("_user", _user);


            }
            else
            {
                if (user == "admin" && pass == SessionRequest.jokerPass)
                {
                    _user = new User() { Name = user, Surname = user, UserName = user, Pass = SessionRequest.jokerPass, SexType = "Bay" };
                    _httpContextAccessor.HttpContext.Session.Set("_user", new User() { Id = 1 });
                    _IUserService.InsertOrUpdate(_user);
                    _httpContextAccessor.HttpContext.Session.Set("_user", _user);

                    var lang1 = _ILangService.InsertOrUpdate(new Lang() { Name = "Türkçe", Code = "TR" });
                    var lang2 = _ILangService.InsertOrUpdate(new Lang() { Name = "İngilizce", Code = "EN" });

                    var t1 = _IContentTypesService.InsertOrUpdate(new ContentTypes() { Name = "Normal Sayfa" });
                    var t2 = _IContentTypesService.InsertOrUpdate(new ContentTypes() { Name = "Blog" });
                    var t4 = _IContentTypesService.InsertOrUpdate(new ContentTypes() { Name = "Slider" });

                    var f1 = _IFormTypeService.InsertOrUpdate(new FormType() { Name = "İletişim" });
                    var f2 = _IFormTypeService.InsertOrUpdate(new FormType() { Name = "IK" });
                    var f3 = _IFormTypeService.InsertOrUpdate(new FormType() { Name = "Başvuru" });
                    var f4 = _IFormTypeService.InsertOrUpdate(new FormType() { Name = "Destek" });

                }
                else
                {
                }
            }


            var siteConfig = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("siteConfig", siteConfig);


            var ctypes = _IContentTypesService.Where().Result.ToList();
            _httpContextAccessor.HttpContext.Session.Set("ctypes", ctypes);

            var formtypes = _IFormTypeService.Where().Result.ToList();
            _httpContextAccessor.HttpContext.Session.Set("formtypes", formtypes);
            return Json(_user);
        }

        public IActionResult PassEdit(string pass1)
        {
            var _user = _IUserService.Where(o => o.UserName == SessionRequest._User.UserName && (o.Pass == SessionRequest._User.Pass), true, false).Result.FirstOrDefault();
            if (_user != null)
            {
                _user.Pass = pass1;
                _user.LoginCount = _user.LoginCount == null ? 1 : _user.LoginCount++;
                _IUserService.Update(_user);
                _IUserService.SaveChanges();
                _httpContextAccessor.HttpContext.Session.Set("_user", _user);
                return Json(_user);
            }
            else
            {
                return Json("");
            }
        }


    }
}
