#pragma checksum "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4e4386967a3d5c6ebfe4dfee4c757dc21268aca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContentPage_InsertOrUpdatePage), @"mvc.1.0.view", @"/Views/ContentPage/InsertOrUpdatePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e4386967a3d5c6ebfe4dfee4c757dc21268aca", @"/Views/ContentPage/InsertOrUpdatePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6013e9fc86e00b5e371ee2add54958b5690286", @"/Views/_ViewImports.cshtml")]
    public class Views_ContentPage_InsertOrUpdatePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
   var postModel = ViewBag.postModel as ContentPage;
    var selecttype = Context.Request.Query["selecttype"].ToInt();
    var selectname = Context.Request.Query["selectname"].ToStr();
    var EnumText = selectname;
    var disabled = "BannerText,BannerButtonText,ButtonText,ButtonLink";

    if (postModel == null)
    {
        postModel = new ContentPage();
        postModel.ContentTypesId = selecttype;
        postModel.ContentPageId = null;
    }
    else
    {
        selecttype = postModel.ContentTypesId;
    }
    var TitleName = EnumText + " " + (postModel.Id > 0 ? "Güncelleme" : "Ekleme"); 

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
#line 26 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                             Write(Html.Raw(EnumText));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <!--end::Page Title-->
            <!--begin::Action-->
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
            <a href=""#"" class=""btn btn-light-primary font-weight-bolder btn-sm"">Yeni Kayıt</a>
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
                    <ul class=""tabbar nav nav-tabs nav-bold nav-tabs-line nav-tabs-line-3x"">
                        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#tab1"">");
#nullable restore
#line 48 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                                                  Write(Html.Raw(EnumText + " " + (postModel.Id > 0 ? "Güncelleme" : "Ekleme")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                         if (postModel.Id > 0)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#tab2\">");
#nullable restore
#line 52 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                                               Write(Html.Raw("Medya"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#tab3\">");
#nullable restore
#line 53 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                                               Write(Html.Raw("Spec"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 54 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                </div>\r\n\r\n");
            WriteLiteral("                <a style=\"float:right;margin-top:25px;\" target=\"_blank\" class=\"btn btn-sm btn-clean btn-icon btn-icon-md\"");
            BeginWriteAttribute("href", " href=\"", 2745, "\"", 2793, 3);
#nullable restore
#line 60 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
WriteAttributeValue("", 2752, SessionRequest.layoutUrl, 2752, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2777, "/", 2777, 1, true);
#nullable restore
#line 60 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
WriteAttributeValue("", 2778, postModel.Link, 2778, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Önizleme\">\r\n                    <i class=\"fa fa-eye\"></i>\r\n                </a>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"card-body\">\r\n                <div class=\"tab-content\">\r\n                    <div class=\"tab-pane fade show active\" id=\"tab1\" role=\"tabpanel\" aria-labelledby=\"tab1\">\r\n                        ");
#nullable restore
#line 68 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", new DynamicModel()
                        {
                            model = postModel,
                            controllerName = postModel.GetType().Name,
                            PageType = "ContentPage",
                            titleName = TitleName,
                            InsertMethodName = "InsertOrUpdate",
                            labelClass = "col-md-4",
                            inputClass = "col-md-8",
                            colClass = "col-md-6",
                            nonProp = disabled,
                            orderby = "",
                            addBtn = "<input type='submit' value='" + "Kaydet" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
                            removeBtn = $"<input dataid='{postModel.Id}' type='button' value='Sil' class='btnDelete btn btn-danger btn-shadow-hover font-weight-bold mr-2' />",

                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"tab-pane fade\" id=\"tab2\" role=\"tabpanel\" aria-labelledby=\"tab2\">\r\n                        ");
#nullable restore
#line 86 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", new DynamicModel()
                        {
                            model = postModel,
                            controllerName = postModel.GetType().Name,
                            PageType = "Documents",
                            titleName = "Medya",
                            InsertMethodName = "InsertOrUpdate",
                            labelClass = "col-md-4",
                            inputClass = "col-md-8",
                            colClass = "col-md-6",
                            nonProp = disabled,
                            orderby = "",
                            addBtn = "<input type='submit' value='" + "Ekle" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
                            removeBtn = "",

                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"tab-pane fade\" id=\"tab3\" role=\"tabpanel\" aria-labelledby=\"tab3\">\r\n                        ");
#nullable restore
#line 104 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", new DynamicModel()
                        {
                            model = postModel,
                            controllerName = postModel.GetType().Name,
                            PageType = "SpecDynamic",
                            titleName = TitleName,
                            InsertMethodName = "InsertOrUpdate",
                            labelClass = "col-md-4",
                            inputClass = "col-md-8",
                            colClass = "col-md-6",
                            nonProp = disabled,
                            orderby = "",
                            addBtn = "<input type='submit' value='" + "Kaydet" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
                            removeBtn = "",

                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n    <!--end::Container-->\r\n</div>\r\n<!--end::Entry-->\r\n<!--end::Content-->\r\n<script>\r\n    $(function () {\r\n        $($(\'.tabbar li a\')[0]).click();\r\n    });\r\n</script>");
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
