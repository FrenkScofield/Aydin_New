#pragma checksum "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SiteConfig\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "765d36a5157475a92ee514326cc5f2c298088000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SiteConfig_Index), @"mvc.1.0.view", @"/Views/SiteConfig/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765d36a5157475a92ee514326cc5f2c298088000", @"/Views/SiteConfig/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6013e9fc86e00b5e371ee2add54958b5690286", @"/Views/_ViewImports.cshtml")]
    public class Views_SiteConfig_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SiteConfig\Index.cshtml"
  
    var PageType = "SiteConfig";
    var EnumText = "Site Ayarları";
    var postModel = ViewBag.edit as SiteConfig;
    var selecttype = Context.Request.Query["selecttype"].ToInt();



    var dynamicRow = new DynamicModel()
    {
        model = postModel == null ? new SiteConfig() : postModel,
        controllerName = postModel == null ? new SiteConfig().GetType().Name : postModel.GetType().Name,
        PageType = PageType,
        titleName = EnumText + " " + (postModel?.Id > 0 ? "Güncelleme" : "Ekleme"),
        InsertMethodName = "InsertOrUpdate",
        labelClass = "col-md-4",
        inputClass = "col-md-8",
        colClass = "col-md-6",
        nonProp = "",
        orderby = "",
        addBtn = "<input type='submit' value='" + "Kaydet" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
        //removeBtn = $"<input dataid='{postModel?.Id}' type='button' value='Sil' class='btnDelete btn btn-danger btn-shadow-hover font-weight-bold mr-2' />",

    };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--begin::Content-->
<!--begin::Subheader-->
<div class=""subheader py-2 py-lg-6 subheader-transparent"" id=""kt_subheader"">
    <div class=""container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
        <!--begin::Info-->
        <div class=""d-flex align-items-center flex-wrap mr-2"">
            <!--begin::Page Title-->
            <h5 class=""text-dark font-weight-bold mt-2 mb-2 mr-5"">");
#nullable restore
#line 34 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SiteConfig\Index.cshtml"
                                                             Write(Html.Raw(EnumText));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <!--end::Page Title-->
            <!--begin::Action-->
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
            <!--end::Action-->
        </div>
        <!--end::Info-->

    </div>
</div>
<!--end::Subheader-->
<!--begin::Entry-->
<div class=""d-flex flex-column-fluid"">
    <!--begin::Container-->
    <div class=""container-fluid"">

        <div class=""card card-custom"">
            <div class=""card-header card-header-tabs-line nav-tabs-line-3x"">
                <div class=""card-toolbar"">
                    <ul class=""nav nav-tabs nav-bold nav-tabs-line nav-tabs-line-3x"">
                        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#tab1"">");
#nullable restore
#line 55 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SiteConfig\Index.cshtml"
                                                                                                  Write(Html.Raw(EnumText + " " + (postModel?.Id > 0 ? "Güncelleme" : "Ekleme")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"tab-content\">\r\n                    <div class=\"tab-pane fade show active\" id=\"tab1\" role=\"tabpanel\" aria-labelledby=\"tab1\">\r\n                        ");
#nullable restore
#line 63 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SiteConfig\Index.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", dynamicRow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n    <!--end::Container-->\r\n</div>\r\n<!--end::Entry-->\r\n<!--end::Content-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591