#pragma checksum "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8956fa40d1b656361d7b2dc01fb40c270858bce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_PageHor), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/PageHor.cshtml")]
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
#line 1 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\_ViewImports.cshtml"
using CMSSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8956fa40d1b656361d7b2dc01fb40c270858bce3", @"/Views/Shared/Components/ContentView/PageHor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_PageHor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-10 wow animate__fadeIn margin-20px-top margin-10px-bottom"">
                <div class=""row align-items-center"">
                    <div class=""col-12 col-md-6 sm-margin-30px-bottom wow animate__fadeIn"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeIn;"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 631, "\"", 791, 3);
#nullable restore
#line 12 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
WriteAttributeValue("", 637, SessionRequest.config.ImageUrl, 637, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 668, "/fileupload/UserFiles/Folders/", 668, 30, true);
#nullable restore
#line 12 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
WriteAttributeValue("", 698, content.Picture==null?"default-blog-detail.jpg" +
                "":content.Picture.Link, 698, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 792, "\"", 811, 1);
#nullable restore
#line 13 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
WriteAttributeValue("", 798, content.Name, 798, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-no-retina="""">
                    </div>
                    <div class=""col-12 col-lg-5 offset-lg-1 col-md-6 last-paragraph-no-margin wow animate__fadeIn"" data-wow-delay=""0.4s"" style=""visibility: visible; animation-delay: 0.4s; animation-name: fadeIn;"">
");
            WriteLiteral("                        <h6 class=\"alt-font text-extra-dark-gray margin-35px-bottom font-weight-500 xs-margin-25px-bottom\">");
#nullable restore
#line 17 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
                                                                                                                      Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 18 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
                      Write(content.ContentShort);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-10 wow animate__fadeIn margin-20px-top margin-10px-bottom"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeIn;"">
                ");
#nullable restore
#line 25 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\ContentView\PageHor.cshtml"
           Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
