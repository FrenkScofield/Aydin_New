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
    public class MenuView : ViewComponent
    {
        IHttpContextAccessor _httpContextAccessor;
        IContentPageService _IContentPageService;
        IDocumentsService _IDocumentsService;
        public MenuView(
            IContentPageService _IContentPageService,
            IDocumentsService _IDocumentsService,
        IHttpContextAccessor httpContextAccessor
            )
        {
            this._IContentPageService = _IContentPageService;
            this._httpContextAccessor = httpContextAccessor;
            this._IDocumentsService = _IDocumentsService;
        }
        public IViewComponentResult Invoke(string type)
        {
            #region dynamicContent 
            var link = HttpContext.Request.Path.Value.Trim().Trim('/').ToStr();
            List<ContentPage> contentPages = new List<ContentPage>();
            if (_httpContextAccessor.HttpContext.Session.Get("contentPages") == null)
            {
                contentPages = _IContentPageService.Where(null, true, false).Result.ToList();
                _httpContextAccessor.HttpContext.Session.Set("contentPages", contentPages);
            }
            else
            {
                contentPages =
                _httpContextAccessor.HttpContext.Session.Get<List<ContentPage>>("contentPages");
                _httpContextAccessor.HttpContext.Session.Set("contentPages", contentPages);
            }

            var content = contentPages.Where(o => o.Link == link ).FirstOrDefault(); 
            ViewBag.contentPages = contentPages;
            
            ViewBag.content = content;
            if (type == "SideMenu")
            {
                int parentID = content.ContentPageId ?? 0;
                ContentPage parentContent = new ContentPage();
                if (parentID != 0)
                {
                  //while (contentPages.Any(p => p.Id == parentID))
                  //{
                  //    parentContent = contentPages.FirstOrDefault(p => p.Id == parentID);
                  //
                  //    if (parentContent.ContentPageId == null)
                  //    {
                  //        parentID = parentContent.Id;
                  //        break;
                  //    }
                  //    else
                  //    {
                  //        parentID = parentContent.ContentPageId ?? 0;
                  //    }
                  //}
                    ViewBag.SideMenu = contentPages.Where(x => x.ContentPageId == parentID && x.IsSideMenu == true).OrderBy(o => o.OrderNo).ToList();
               //     List<ContentPage> sideMenus = new List<ContentPage>();
                 //  List<ContentPage> tempList = contentPages.Where(x => x.ContentPageId == parentID).ToList();
                 //  while (true)
                 //  {
                 //      foreach (var item in tempList)
                 //      {
                 //          if (item.IsSideMenu == true)
                 //          {
                 //              sideMenus.Add(item);
                 //          }
                 //      }
                 //      tempList = contentPages.Where(x => x.IsDeleted == null && tempList.Select(x => x.Id).ToList().Contains(x.ContentPageId ?? 0)).ToList();
                 //      if (tempList.SelectMany(x => x.ContentPageChilds).Count() == 0)
                 //      {
                 //          foreach (var item in tempList)
                 //          {
                 //              if (item.IsSideMenu == true)
                 //                  sideMenus.Add(item);
                 //          }
                 //          break;
                 //      }
                 //  }
                   // ViewBag.SideMenu = sideMenus;
                }
                else
                {
                    ViewBag.SideMenu = content;
                }
            }
            #endregion
            return View(type);
        }
    }
}