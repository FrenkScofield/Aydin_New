#pragma checksum "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "797b067e03b021f587171217d497f7b09864d618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_Content), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/Content.cshtml")]
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
#line 1 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\_ViewImports.cshtml"
using CMSSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"797b067e03b021f587171217d497f7b09864d618", @"/Views/Shared/Components/ContentView/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets-site/plugins/lightbox/css/lightgallery.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets-site/plugins/lightbox/js/picturefill.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets-site/plugins/lightbox/js/lightgallery-all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets-site/plugins/lightbox/lib/jquery.mousewheel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "797b067e03b021f587171217d497f7b09864d6185460", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""mission-section"">
                    <div class=""container text-center"">
                        <h2 class=""margin-bottom-50"">");
#nullable restore
#line 13 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                                                Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div class=\"content\">\r\n                            ");
#nullable restore
#line 15 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                       Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 19 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                 if (content.Picture != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row section\">\r\n                        <div class=\"col-12 img\"><img");
            BeginWriteAttribute("src", " src=\"", 903, "\"", 994, 2);
            WriteAttributeValue("", 909, "http://eyuboglucms.hybro.systems/fileupload/UserFiles/Folders/", 909, 62, true);
#nullable restore
#line 22 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 971, content.Picture.Link, 971, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 995, "\"", 1014, 1);
#nullable restore
#line 22 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1001, content.Name, 1001, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></div>\r\n                    </div>\r\n");
#nullable restore
#line 24 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"section\">\r\n                    ");
#nullable restore
#line 26 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
               Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 33 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
     if (content.Gallery != null && content.Gallery.Count > 0)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media-grid\">\r\n            <div class=\"heading text-center\">\r\n                ");
#nullable restore
#line 39 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
           Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\" id=\"lightgallery\">\r\n");
#nullable restore
#line 42 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                 foreach (var item in content.Gallery)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-6 col-lg-3 img\">\r\n                        <a class=\"lb-item\"");
            BeginWriteAttribute("href", " href=\"", 1700, "\"", 1779, 2);
            WriteAttributeValue("", 1707, "http://eyuboglucms.hybro.systems/fileupload/UserFiles/Folders/", 1707, 62, true);
#nullable restore
#line 45 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1769, item.Link, 1769, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1785, "\"", 1863, 2);
            WriteAttributeValue("", 1791, "http://eyuboglucms.hybro.systems/fileupload/UserFiles/Folders/", 1791, 62, true);
#nullable restore
#line 45 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1853, item.Link, 1853, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1864, "\"", 1879, 1);
#nullable restore
#line 45 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1870, item.Alt, 1870, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n                    </div>\r\n");
#nullable restore
#line 47 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 50 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "797b067e03b021f587171217d497f7b09864d61812623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "797b067e03b021f587171217d497f7b09864d61813663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "797b067e03b021f587171217d497f7b09864d61814703", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n\r\n        $(\'#lightgallery\').lightGallery({\r\n            selector: \'.lb-item\'\r\n        });\r\n    });\r\n</script>");
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
