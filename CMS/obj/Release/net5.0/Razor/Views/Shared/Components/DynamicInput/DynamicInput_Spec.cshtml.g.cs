#pragma checksum "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fba892ddc7426d95ff32ad91d4b033534667809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DynamicInput_DynamicInput_Spec), @"mvc.1.0.view", @"/Views/Shared/Components/DynamicInput/DynamicInput_Spec.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fba892ddc7426d95ff32ad91d4b033534667809", @"/Views/Shared/Components/DynamicInput/DynamicInput_Spec.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6013e9fc86e00b5e371ee2add54958b5690286", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DynamicInput_DynamicInput_Spec : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frm_spec"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm_spec"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
   var postModel = Model.model as ContentPage;
    var ContentPageId = postModel.Id;
    var spec = ViewBag.spec as List<Spec>; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    var ContentPageId = \"");
#nullable restore
#line 10 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                    Write(ContentPageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n</script>\r\n<div");
            BeginWriteAttribute("formdata", " formdata=\"", 230, "\"", 268, 1);
#nullable restore
#line 12 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 241, Model.model.GetType().Name, 241, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fba892ddc7426d95ff32ad91d4b0335346678095963", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
         foreach (var item in spec.Where(o => o.IsTanim == true).OrderBy(o => o.OrderNo))
        {
            switch (item.SpecType)
            {
                case SpecType.tanim:
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row mb-4 mt-4\">\r\n                            <div class=\"col-12\">\r\n                                <h1>");
#nullable restore
#line 22 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 25 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                        if (item.SpecChilds.Any())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"row mt-2 mb-2\">\r\n");
#nullable restore
#line 28 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                 foreach (var item2 in item.SpecChilds)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div");
                BeginWriteAttribute("class", " class=\"", 1054, "\"", 1129, 4);
                WriteAttributeValue("", 1062, "mt-2", 1062, 4, true);
                WriteAttributeValue(" ", 1066, "mb-2", 1067, 5, true);
                WriteAttributeValue(" ", 1071, "col-", 1072, 5, true);
#nullable restore
#line 30 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 1076, Html.Raw(item2.SpecType==SpecType.editor ? "12":"2"), 1076, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <label>");
#nullable restore
#line 31 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                          Write(item2.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 32 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                         switch (item2.SpecType)
                                        {
                                            case SpecType.check:
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <span class=\"switch\">\r\n                                                        <label>\r\n");
#nullable restore
#line 38 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                             if (item2.SpecContentValue?.FirstOrDefault(x => x.ContentPageId == ContentPageId && x.SpecId == item2.Id)?.ContentValue == "true")
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <input checked=\"checked\"");
                BeginWriteAttribute("ContentPageId", " ContentPageId=\"", 1911, "\"", 1941, 1);
#nullable restore
#line 40 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 1927, ContentPageId, 1927, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("SpecId", " SpecId=\"", 1942, "\"", 1960, 1);
#nullable restore
#line 40 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 1951, item2.Id, 1951, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dataid=\"item_check\"");
                BeginWriteAttribute("id", " id=\"", 1981, "\"", 2003, 2);
                WriteAttributeValue("", 1986, "check_", 1986, 6, true);
#nullable restore
#line 40 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 1992, item2.Name, 1992, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2004, "\"", 2028, 2);
                WriteAttributeValue("", 2011, "check_", 2011, 6, true);
#nullable restore
#line 40 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2017, item2.Name, 2017, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\"> ");
#nullable restore
#line 40 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                                                                                                                                                                }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <input");
                BeginWriteAttribute("ContentPageId", " ContentPageId=\"", 2249, "\"", 2279, 1);
#nullable restore
#line 43 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2265, ContentPageId, 2265, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("SpecId", " SpecId=\"", 2280, "\"", 2298, 1);
#nullable restore
#line 43 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2289, item2.Id, 2289, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dataid=\"item_check\"");
                BeginWriteAttribute("id", " id=\"", 2319, "\"", 2341, 2);
                WriteAttributeValue("", 2324, "check_", 2324, 6, true);
#nullable restore
#line 43 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2330, item2.Name, 2330, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2342, "\"", 2366, 2);
                WriteAttributeValue("", 2349, "check_", 2349, 6, true);
#nullable restore
#line 43 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2355, item2.Name, 2355, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\">");
#nullable restore
#line 43 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                                                                                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <span></span>\r\n                                                        </label>\r\n                                                    </span> ");
#nullable restore
#line 46 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                            }
                                                break;
                                            case SpecType.list://drop
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <select");
                BeginWriteAttribute("ContentPageId", " ContentPageId=\"", 2828, "\"", 2858, 1);
#nullable restore
#line 50 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2844, ContentPageId, 2844, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("SpecId", " SpecId=\"", 2859, "\"", 2877, 1);
#nullable restore
#line 50 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2868, item2.Id, 2868, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dataid=\"item_list\" class=\"form-control form-control-solid form-control-lg\"");
                BeginWriteAttribute("id", " id=\"", 2953, "\"", 2974, 2);
                WriteAttributeValue("", 2958, "list_", 2958, 5, true);
#nullable restore
#line 50 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2963, item2.Name, 2963, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2975, "\"", 2998, 2);
                WriteAttributeValue("", 2982, "list_", 2982, 5, true);
#nullable restore
#line 50 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 2987, item2.Name, 2987, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fba892ddc7426d95ff32ad91d4b03353466780917097", async() => {
                    WriteLiteral("Se??iniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                         foreach (var attr in item2.SpecAttrs)
                                                        {
                                                            if (item2.SpecContentValue?.FirstOrDefault()?.ContentValue == attr.AttrValue)
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fba892ddc7426d95ff32ad91d4b03353466780918962", async() => {
#nullable restore
#line 56 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                                               Write(attr.AttrValue);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                       WriteLiteral(attr.AttrValue);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fba892ddc7426d95ff32ad91d4b03353466780921573", async() => {
#nullable restore
#line 60 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                           Write(attr.AttrValue);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                   WriteLiteral(attr.AttrValue);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                            }
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </select> ");
#nullable restore
#line 63 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                              }

                                                break;
                                            case SpecType.text:
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <input");
                BeginWriteAttribute("ContentPageId", " ContentPageId=\"", 4325, "\"", 4355, 1);
#nullable restore
#line 68 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 4341, ContentPageId, 4341, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("SpecId", " SpecId=\"", 4356, "\"", 4374, 1);
#nullable restore
#line 68 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 4365, item2.Id, 4365, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dataid=\"item_text\"");
                BeginWriteAttribute("id", " id=\"", 4394, "\"", 4415, 2);
                WriteAttributeValue("", 4399, "text_", 4399, 5, true);
#nullable restore
#line 68 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 4404, item2.Name, 4404, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4416, "\"", 4439, 2);
                WriteAttributeValue("", 4423, "text_", 4423, 5, true);
#nullable restore
#line 68 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 4428, item2.Name, 4428, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4440, "\"", 4576, 1);
#nullable restore
#line 68 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
WriteAttributeValue("", 4448, Html.Raw(item2.SpecContentValue?.Where(x=>x.ContentPageId==ContentPageId && x.SpecId==item2.Id).FirstOrDefault()?.ContentValue), 4448, 128, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\" form-control form-control-solid form-control-lg\" /> ");
#nullable restore
#line 68 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                   }
                                                break;
                                            case SpecType.editor:
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                Write(Html.Kendo().Editor()
                                                          .Name("editor_" + item2.Id).Encoded(false).PasteCleanup(p => p.All())
                                                          .HtmlAttributes(new { ContentPageId = ContentPageId, SpecId = item2.Id, dataid ="item_editor", style = "width: 100%; height:200px", aria_label = "editor" })
                                                          .Tools(tools => tools
                                                            .Clear()
                                                            .Bold().Italic().Underline()
                                                            .JustifyLeft().JustifyCenter().JustifyRight()
                                                            .InsertUnorderedList().InsertOrderedList()
                                                            .Outdent().Indent()
                                                            .CreateLink().Unlink()
                                                            .InsertImage()
                                                            .TableEditing()
                                                            .FontName()
                                                            .FontSize()
                                                            //.BackColor()
                                                            .FontColor().BackColor().JustifyFull().ViewHtml().Formatting()
                                                          )
                                                          .ImageBrowser(imageBrowser =>
                                                          {
                                                              imageBrowser.Image("~/fileupload/UserFiles/Folders/{0}");
                                                              imageBrowser.Read("Read", "FileManagerData");
                                                              imageBrowser.Create("Create", "FileManagerData");
                                                              imageBrowser.Destroy("Destroy", "FileManagerData");
                                                              imageBrowser.Upload("Upload", "FileManagerData");
                                                              //imageBrowser.Thumbnail("Thumbnail", "FileManagerData");
                                                          }
                                                      ).Value(item2.SpecContentValue?.FirstOrDefault(o=>o.ContentPageId == ContentPageId)?.ContentValue));

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                                                                                                                                         }
                                                break;
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>");
#nullable restore
#line 101 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>");
#nullable restore
#line 102 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
                                  }
                    }
                    break;

            }

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"float-right\">\r\n            ");
#nullable restore
#line 111 "D:\Users\DELL\Source\Repos\Aydin_New\CMS\Views\Shared\Components\DynamicInput\DynamicInput_Spec.cshtml"
       Write(Html.Raw(Model.addBtn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>

<script>
    $(function () {



        $(""#frm_spec"").submit(function (e) {
            e.preventDefault();
            var postModel = [];

            var items = $('[dataid=""item_check""],[dataid=""item_list""],[dataid=""item_text""],[dataid=""item_editor""]')
            $.each(items, function (i, item) {
                postModel.push({
                    SpecId: $(item).attr('SpecId'),
                    ContentPageId: $(item).attr('ContentPageId'),
                    ContentValue: $(item).attr('dataid') == ""item_check"" ? toStr($(item).is(':checked')) : $(item).val()
                });
            });

            $.LoadingOverlay(""show"");
            $.ajx('/SpecContentValue/InsertOrUpdateBulk',
                { postModel: postModel }, function (resultData) {
                    try {
                        var messageStr = """";
                        $.each(resultData, function (i, item) {
                            debugger;
                            if (item");
            WriteLiteral(@".ResultType.MessageList.length > 0)
                                messageStr += item.ResultType.MessageList;
                        });
                        if (messageStr) {
                            alert(""Bir hatayla kar????la????ld??. L??tfen Kontrol ediniz."");
                        }
                        else {
                            alert(""Spec' ler g??ncellendi"")
                        }
                        //$('.tabbar.nav.nav-tabs.nav-bold.nav-tabs-line.nav-tabs-line-3x li a:last').click()

                    } catch (ex) {
                        alert(""Bir hatayla kar????la????ld??. L??tfen Kontrol ediniz."");

                    }

                    $.LoadingOverlay(""hide"");
                }, function () { location.reload(); });
        });
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
