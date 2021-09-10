using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMSSite.Components
{

    public class ContentView : ViewComponent
    {

       
        ISiteConfigService _ISiteConfigService;
        IFormTypeService _IFormTypeService;
        IHttpContextAccessor _httpContextAccessor;
        IContentPageService _IContentPageService;
        ISpecService _ISpecService;
        IDocumentsService _IDocumentsService; 
        public ContentView(
            IContentPageService _IContentPageService,
            ISpecService _ISpecService,
        IDocumentsService _IDocumentsService,
        IHttpContextAccessor httpContextAccessor,
        IFormTypeService _IFormTypeService,
          ISiteConfigService _ISiteConfigService
            )
        {
            this._IContentPageService = _IContentPageService;
            this._ISpecService = _ISpecService;
            this._httpContextAccessor = httpContextAccessor;
            this._IDocumentsService = _IDocumentsService;
            this._IFormTypeService = _IFormTypeService;
            this._ISiteConfigService = _ISiteConfigService;
        }

        public IViewComponentResult Invoke(TemplateType TemplateType)
        {
            var link = HttpContext.Request.Path.Value.Trim('/').ToStr();

            var config = _ISiteConfigService.Where().Result.FirstOrDefault();
            _httpContextAccessor.HttpContext.Session.Set("config", config);

            List<ContentPage> contentPages = new List<ContentPage>();
            contentPages = _IContentPageService.Where(x => x.IsPublish == true && x.IsActive == true, true, false, o => o.ContentPageChilds, o => o.Parent, o => o.Gallery, o => o.Documents, o => o.ThumbImage, o => o.Picture, o => o.BannerImage,o=>o.SpecContentValue).Result.ToList();
            _httpContextAccessor.HttpContext.Session.Set("contentPages", contentPages);
            ViewBag.Pages = contentPages;
            var content = contentPages.FirstOrDefault(o => o.Link.ToLower() == link.ToLower());
            ViewBag.Portals = contentPages.Where(x => x.ContentPageId == 136).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();
            ViewBag.IsHeaderMenu = contentPages.Where(o => o.IsHeaderMenu == true).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();
            ViewBag.IsFooterMenu = contentPages.Where(o => o.IsFooterMenu == true).OrderBy(o => o.OrderNo).ThenBy(o => o.Name).ToList();
            if (TemplateType == TemplateType.BlogList )
            {
                ViewBag.contents = contentPages.Where(x => x.ContentPageId == 4 && x.IsDeleted == null && x.IsActive==true).OrderBy(o => o.OrderNo).ToList();

           
            }
            else if (TemplateType == TemplateType.BlogDetail )
            {
                ViewBag.contents = contentPages.Where(x => x.ContentPageId == content.ContentPageId && x.IsDeleted == null && x.Id != content.Id).OrderBy(o => o.OrderNo).ToList();
            }
             


            ViewBag.content = content;

            ViewBag.MetaTitle = content.Name+ " | Aydın Grup";
            ViewBag.MetaDescription = string.IsNullOrEmpty(content.ContentShort)? "Aydın Grup" : content.ContentShort;
            return View(TemplateType.ToString());
        }
    }
}