#pragma checksum "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SpecAttr\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b463c8932bf0b4a074247acef9dfddcb1d7b0b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpecAttr_Index), @"mvc.1.0.view", @"/Views/SpecAttr/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b463c8932bf0b4a074247acef9dfddcb1d7b0b8b", @"/Views/SpecAttr/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6013e9fc86e00b5e371ee2add54958b5690286", @"/Views/_ViewImports.cshtml")]
    public class Views_SpecAttr_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SpecAttr\Index.cshtml"
  
    var pageName = "SpecAttr";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--begin::Content-->
<!--begin::Subheader-->
<div class=""subheader py-2 py-lg-6 subheader-transparent"" id=""kt_subheader"">
    <div class=""container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
        <!--begin::Info-->
        <div class=""d-flex align-items-center flex-wrap mr-2"">
            <!--begin::Page Title-->
            <h5 class=""text-dark font-weight-bold mt-2 mb-2 mr-5"">");
#nullable restore
#line 11 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SpecAttr\Index.cshtml"
                                                             Write(Html.Raw("SpecAttr"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <!--end::Page Title-->
            <!--begin::Action-->
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
            <a");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 814, 3);
            WriteAttributeValue("", 775, "/", 775, 1, true);
#nullable restore
#line 16 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SpecAttr\Index.cshtml"
WriteAttributeValue("", 776, Html.Raw(pageName), 776, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 795, "/InsertOrUpdatePage", 795, 19, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-light-primary font-weight-bolder btn-sm"">Yeni Kayıt</a>
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
        <div class=""row"">
            <div class=""col-12"">
                ");
#nullable restore
#line 30 "D:\Users\FRENK\source\repos\Hibrit\AYDIN\CMS\Views\SpecAttr\Index.cshtml"
            Write(Html.Kendo().Grid<SpecAttr>().Name("grid_"+ pageName)
                .Columns(columns => {
                    columns.Bound(o => o.Id).Groupable(false);
                    columns.Bound(p => p.Spec.Name).Title("Spec Ad");
                    //columns.Bound(p => p.Spec.SpecType).Title("Spec Tipi");
                    columns.Bound(o => o.AttrValue).Title("Value");

                    columns.Bound(p => p.Id)
                    .Sortable(false)
                    .Title("Detay")
                    .ClientTemplate("<a class='btn btn-sm btn-clean btn-icon btn-icon-md' href='/"+pageName+"/InsertOrUpdatePage?id=#=Id#' title='Detay'><i class='la la-edit'></i></a>");
                })
            .Pageable()
            .Sortable()
            .Filterable()
            .Scrollable()
            .Resizable(r => r.Columns(true))
            .Reorderable(r => r.Columns(true))
            .DataSource(dataSource =>
            dataSource
            .Ajax().Events(events => events.Error("error_handler"))
            .Read(read => read.Action("GetPaging", pageName))
            .PageSize(15)
            )
            );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>


    </div>
    <!--end::Container-->
</div>
<!--end::Entry-->
<!--end::Content-->

<script>
    function error_handler(e) {
        if (e.errors) {
            var message = ""Errors:\n"";
            $.each(e.errors, function (key, value) {
                if ('errors' in value) {
                    $.each(value.errors, function () {
                        message += this + ""\n"";
                    });
                }
            });
            alert(message);
        }
    }

</script>");
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
