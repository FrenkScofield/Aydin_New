#pragma checksum "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\SectionView\SaltGalleryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0798861d7c9906a013c1318072af6f4d44c489ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SectionView_SaltGalleryList), @"mvc.1.0.view", @"/Views/Shared/Components/SectionView/SaltGalleryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0798861d7c9906a013c1318072af6f4d44c489ab", @"/Views/Shared/Components/SectionView/SaltGalleryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SectionView_SaltGalleryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\SectionView\SaltGalleryList.cshtml"
  
    Layout = null;
    var content = ViewBag.content as ContentPage;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container project-view"">
        <section class=""wpb_row vc_row-fluid"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""wpb_column vc_column_container vc_col-sm-12"">
                        <div class=""vc_column-inner "">
                            <div class=""wpb_wrapper ""> 
");
#nullable restore
#line 13 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\SectionView\SaltGalleryList.cshtml"
                                 foreach (var item in content.Gallery)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""wpb_single_image wpb_content_element""> 
                                        <figure class=""wpb_wrapper vc_figure"">
                                            <div class=""vc_single_image-wrapper   vc_box_border_grey"">
                                                <img width=""1024"" height=""678""");
            BeginWriteAttribute("src", " src=\"", 892, "\"", 970, 2);
            WriteAttributeValue("", 898, "http://eyuboglucms.hybro.systems/fileupload/UserFiles/Folders/", 898, 62, true);
#nullable restore
#line 18 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\SectionView\SaltGalleryList.cshtml"
WriteAttributeValue("", 960, item.Link, 960, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"vc_single_image-img attachment-full\"");
            BeginWriteAttribute("alt", " alt=\"", 1015, "\"", 1031, 1);
#nullable restore
#line 18 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\SectionView\SaltGalleryList.cshtml"
WriteAttributeValue("", 1021, item.Name, 1021, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </div>\r\n                                        </figure>\r\n                                    </div>\r\n");
#nullable restore
#line 22 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Shared\Components\SectionView\SaltGalleryList.cshtml"
                                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>");
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
