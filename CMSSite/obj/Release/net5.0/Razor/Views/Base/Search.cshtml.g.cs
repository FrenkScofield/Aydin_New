#pragma checksum "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e3937a732e3d0d399319a0030c203afeb2e6ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Base_Search), @"mvc.1.0.view", @"/Views/Base/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e3937a732e3d0d399319a0030c203afeb2e6ed", @"/Views/Base/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Base_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-left form-style-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
  
    Layout = "_Layout";
    var contents = ViewBag.contents as List<ContentPage>;

    var classEvent = "odd-event";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""section mb-2"">
    <div class=""breadcrub-style-camp"" style=""height: 500px;background-image: url(/uploads/08ab60ae-9_bg-1.png)"">
        <div class=""container"">
            <div class=""heading"" style=""width: 600px;    height: 40px;"">
                <h1 style=""font-family: helvetica;    font-size: 50px;"">Arama</h1>
            </div>
        </div>
    </div>
</div>

<section class=""events-section-style-2 section"">
    <!-- Side Icons -->
");
            WriteLiteral("    <div class=\"container\">\r\n\r\n");
#nullable restore
#line 27 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
         if (contents != null && contents.Count > 0)
        {
            foreach (var item in contents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"event\">\r\n\r\n");
            WriteLiteral("                        <div class=\"col-12 col-lg-12 details\">\r\n                            <h4>");
#nullable restore
#line 46 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>\r\n                                ");
#nullable restore
#line 48 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
                           Write(Html.Raw(item.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n");
#nullable restore
#line 50 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
                              
                                if (classEvent == "odd-event")
                                {
                                    classEvent = "even-event";
                                }
                                else
                                {
                                    classEvent = "odd-event";
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"main-btn\"");
            BeginWriteAttribute("href", " href=\"", 3359, "\"", 3377, 2);
            WriteAttributeValue("", 3366, "/", 3366, 1, true);
#nullable restore
#line 74 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
WriteAttributeValue("", 3367, item.Link, 3367, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Devamı</a>\r\n                        </div>\r\n                    </div>\r\n\r\n");
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 98 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
            }

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-12 col-lg-12 text-center \">Sonuç bulunamadı</div>\r\n            </div>\r\n");
#nullable restore
#line 106 "D:\Users\DELL\Source\Repos\Aydin_New\CMSSite\Views\Base\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    </div>
</section>
<!-- Pagination -->
<!--<div class=""pagination-section section d-flex justify-content-center"">
    <div class=""pagination-style-2"">
        <a class=""prev"" role=""button"" data-slide=""prev"">
            <i class=""flaticon-back""></i>
        </a>
        <div class=""page-num"">
            <a class=""current"">01</a>
            <div class=""page-indicators"">
                <div class=""indicator active""></div>
                <div class=""indicator""></div>
                <div class=""indicator""></div>
                <div class=""indicator""></div>
                <div class=""indicator""></div>
                <div class=""indicator""></div>
            </div>
            <a class=""total"">06</a>
        </div>
        <a class=""next"" role=""button"" data-slide=""next"">
            <i class=""flaticon-next""></i>
        </a>
    </div>
</div>-->
<!-- Popup -->
<div class=""side-form-popup"">
    <div class=""popup-wrapper"">
        <div class=""center-popup"">
            <d");
            WriteLiteral(@"iv class=""opening-popup"">
                <div class=""close-popup"">
                    <i class=""fas fa-times""></i>
                </div>
                <div class=""row"">
                    <div class=""col-md-6 col-lg-8 media"">
                        <img src=""assets/img/University/students/adolescent-adorable-alone.png"" alt=""media""
                             class=""img-fluid"">
                    </div>
                    <div class=""col-md-6 col-lg-4 content"">
                        <h5>Opening hours</h5>
                        <div class=""openings"">
                            <div class=""opening opening-days"">
                                <p class=""day"">Monday</p>
                                <div class=""divider""></div>
                                <p class=""day"">Friday</p>
                            </div>
                            <div class=""opening opening-time"">
                                <p class=""time"">08.00 am</p>
                                <div c");
            WriteLiteral(@"lass=""divider""></div>
                                <p class=""time"">16.00 pm</p>
                            </div>
                        </div>
                        <p class=""num"">+24 45 15 62 129</p>
                    </div>
                </div>
            </div>
            <div class=""location-popup"">
                <div class=""close-popup"">
                    <i class=""fas fa-times""></i>
                </div>
                <div class=""row"">
                    <div class=""col-12 col-md-6 col-lg-8 media"">
                        <div id=""location-map""></div>
                    </div>
                    <div class=""col-12 col-md-6 col-lg-4 content"">
                        <h5>Address</h5>
                        <p class=""address"">2, Ave Manchester, Lorem ipsum St, Rio Danubin</p>
                        <button class=""main-btn"">Open in Maps</button>
                    </div>
                </div>
            </div>
            <div class=""form-popup"">
        ");
            WriteLiteral(@"        <div class=""close-popup"">
                    <i class=""fas fa-times""></i>
                </div>
                <div class=""row"">
                    <div class=""col-12 col-lg-7 content"">
                        <h4>You have a question for us?</h4>
                        <p>leave your message below or email us at info@eyuboglu.com.tr</p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7e3937a732e3d0d399319a0030c203afeb2e6ed10796", async() => {
                WriteLiteral(@"
                            <div class=""form-group required"">
                                <label for=""email"">Email address</label>
                                <input type=""email"" id=""email"" class=""form-control"" name=""email""
                                       placeholder=""johnLP12@gmail.com"" />
                            </div>
                            <div class=""form-group"">
                                <label for=""message"">Message</label>
                                <input type=""text"" id=""message"" class=""form-control"" name=""name""
                                       placeholder=""Hello, I wanted to know about this particular course called..."" />
                                <span class=""small-text"">120 characters left</span>
                            </div>
                            <button class=""main-btn"" type=""submit"">Send message</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""d-none d-lg-block col-lg-5 media"">
                        <img src=""assets/img/University/Coming_soon/ambar-simpang.png""
                             alt=""media image"" class=""img-fluid"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
