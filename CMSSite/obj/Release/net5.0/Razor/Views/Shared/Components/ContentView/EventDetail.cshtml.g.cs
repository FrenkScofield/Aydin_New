#pragma checksum "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d8a7169504caec0bfa66e7a40f5df441c8f0b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_EventDetail), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/EventDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d8a7169504caec0bfa66e7a40f5df441c8f0b4", @"/Views/Shared/Components/ContentView/EventDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_EventDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;
    var contents = ViewBag.contents as List<ContentPage>;


#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 

<!-- Event Detail -->
<div class=""event-detail margin-top-70 margin-bottom-50"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""d-none d-md-block col-5 "">
                <!-- Event cover goes here -->
                <img class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 503, "\"", 522, 1);
#nullable restore
#line 17 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
WriteAttributeValue("", 509, content.Name, 509, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 523, "\"", 651, 2);
            WriteAttributeValue("", 529, "http://eyuboglucms.hybro.systems/fileupload/UserFiles/Folders/", 529, 62, true);
#nullable restore
#line 17 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
WriteAttributeValue("", 591, content.ThumbImage == null ? "" : content.ThumbImage.Link, 591, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-12 col-md-7 col-lg-5 content\">\r\n                <h2 class=\"margin-bottom-30\"> ");
#nullable restore
#line 20 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
                                         Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"my-5\">\r\n                    ");
#nullable restore
#line 22 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
               Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
#nullable restore
#line 24 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
           Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"date\">\r\n                    <div class=\"divider\"></div>\r\n                    <h1>");
#nullable restore
#line 27 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
                    Write(string.IsNullOrEmpty(content.StartDate.ToString())?"": content.StartDate.Day.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                    <h5>");
#nullable restore
#line 28 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
                    Write(string.IsNullOrEmpty(content.StartDate.ToString())?"": content.StartDate.ToString("MMMM").Substring(0, 3).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
                                                                                                                                           Write(string.IsNullOrEmpty(content.StartDate.ToString())?"": content.StartDate.Year.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                </div>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 44 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMSSite\Views\Shared\Components\ContentView\EventDetail.cshtml"
           Write(await Component.InvokeAsync("SectionView", new { type = "Forms" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
