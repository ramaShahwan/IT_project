#pragma checksum "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f03a726146e7d44ef26f6686878617a5af5448f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admain_Views_OpinionEntities_Index), @"mvc.1.0.view", @"/Areas/Admain/Views/OpinionEntities/Index.cshtml")]
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
#line 1 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\_ViewImports.cshtml"
using learnIte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\_ViewImports.cshtml"
using learnIte.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
using ITE_Project.Dto.Opinion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03a726146e7d44ef26f6686878617a5af5448f8", @"/Areas/Admain/Views/OpinionEntities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54af393d08a20e75b6b1ffb5b6a591ccff70bc3", @"/Areas/Admain/Views/_ViewImports.cshtml")]
    public class Areas_Admain_Views_OpinionEntities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ITE_Project.Dto.Opinion.OpinionDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OpreationButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f03a726146e7d44ef26f6686878617a5af5448f87079", async() => {
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"whitebg border\">\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2 class=\"text-info\"> Opinion List</h2>\r\n            <p class=\"text-primary\">The Number of Opinion Is: ");
#nullable restore
#line 49 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                                                         Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("   </p>\r\n        </div>\r\n        <div class=\"col-4 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f03a726146e7d44ef26f6686878617a5af5448f88845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n");
#nullable restore
#line 56 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-danger\"> No Opinion ..</p>\r\n");
#nullable restore
#line 59 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped border "">
                <tr class=""table-secondary"">
                    <th style=""color: #730075; font-size: 1.3em; "">
                        Name
                    </th>
                    <th style=""color: #730075; font-size: 1.3em; "">
                        Email
                    </th>
                    <th style=""color: #730075; font-size: 1.3em; "">
                        Massage
                    </th>
                    <th>

                    </th>
                </tr>
");
#nullable restore
#line 78 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                 foreach (var item in Model)
                {
                    var mid = "myModal" + item.OpinionsId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 3502, "\"", 3511, 1);
#nullable restore
#line 81 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
WriteAttributeValue("", 3507, mid, 3507, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade\">\r\n\r\n                        <div class=\"modal-dialog\">\r\n                            <div class=\"modal-content\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f03a726146e7d44ef26f6686878617a5af5448f812152", async() => {
                WriteLiteral(@"
                                    <div class=""modal-header"">
                                        <h4 class=""modal-title"">Delete Opinion</h4>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                    </div>
                                    <div class=""modal-body"">
                                        <p>Are you sure you want to delete these Records?</p>
                                    </div>
                                    <div class=""modal-footer"">
                                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f03a726146e7d44ef26f6686878617a5af5448f813189", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                                                                    WriteLiteral(item.OpinionsId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 103 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 106 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 109 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"width:15px\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f03a726146e7d44ef26f6686878617a5af5448f818223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 112 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.OpinionsId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 115 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 117 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Areas\Admain\Views\OpinionEntities\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"justify-content-center\">\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f03a726146e7d44ef26f6686878617a5af5448f820726", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ITE_Project.Dto.Opinion.OpinionDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
