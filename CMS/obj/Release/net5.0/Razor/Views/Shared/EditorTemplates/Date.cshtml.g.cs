#pragma checksum "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\Shared\EditorTemplates\Date.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19bc94313b5e2f73ffd14555b58b1b1b8ab83ee9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Date), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Date.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19bc94313b5e2f73ffd14555b58b1b1b8ab83ee9", @"/Views/Shared/EditorTemplates/Date.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6013e9fc86e00b5e371ee2add54958b5690286", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Date : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\Shared\EditorTemplates\Date.cshtml"
Write(Html.Kendo().DatePickerFor(m => m));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime?> Html { get; private set; }
    }
}
#pragma warning restore 1591
