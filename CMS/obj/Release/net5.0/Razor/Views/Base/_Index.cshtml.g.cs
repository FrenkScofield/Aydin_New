#pragma checksum "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Base\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd1b763536e43d36080f73e55cef57224acac0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Base__Index), @"mvc.1.0.view", @"/Views/Base/_Index.cshtml")]
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
#line 1 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd1b763536e43d36080f73e55cef57224acac0c", @"/Views/Base/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6013e9fc86e00b5e371ee2add54958b5690286", @"/Views/_ViewImports.cshtml")]
    public class Views_Base__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <a href=""/Base/FileManager?id=1"" class=""mymodal btn-bg-success"" data-toggle=""modal"" data-target=""#ajaxSub"">File manager</a>
    </div>
</div> 
<script>
    ayarlar();
</script>
<div class=""row"">
    <div class=""col-12"">
        ");
#nullable restore
#line 11 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Base\_Index.cshtml"
    Write(Html.Kendo().Grid<UserModel>()
            .Name("Grid")
            .Columns(columns => {
            columns.Bound(o => o.Id).Groupable(false);
            columns.Bound(o => o.Name);
            columns.Bound(o => o.Surname);
            columns.Bound(o => o.UserName);
            columns.Bound(o => o.BirdhDay);
            })
            .Pageable()
            .Sortable()
            .Filterable()
            .Scrollable()
            .Groupable()
            .DataSource(dataSource => dataSource
            .Ajax()
            .Read(read => read.Action("GetPaging", "Base"))
            .PageSize(15)
            )
            );

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </div>\r\n</div>\r\n");
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
