#pragma checksum "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e1f617cd72e9204c44abca4973a50539fadaa5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_Edit), @"mvc.1.0.view", @"/Views/AdminRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminRole/Edit.cshtml", typeof(AspNetCore.Views_AdminRole_Edit))]
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
#line 7 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp;

#line default
#line hidden
#line 9 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#line 11 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.Models;

#line default
#line hidden
#line 12 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.WebUI.Entity;

#line default
#line hidden
#line 13 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.WebUI.Models;

#line default
#line hidden
#line 15 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 18 "C:\Users\malig\source\repos\MyApp\MyApp\Views\_ViewImports.cshtml"
using DevExpress.XtraReports.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1f617cd72e9204c44abca4973a50539fadaa5c", @"/Views/AdminRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"214624807db7ada68b18eda96fdd97ce43579cdd", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(60, 76, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n/*role name\r\nmembers in this role\r\nmembers not in\r\n*/\r\n\r\n");
            EndContext();
            BeginContext(136, 2314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b255a9f64204f01992bfe3e5907d7be", async() => {
                BeginContext(156, 40, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(196, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbcacedd3852407d817c47bd00131b19", async() => {
                    BeginContext(231, 10, true);
                    WriteLiteral("Role Name:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 15 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Role.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(249, 39, true);
                WriteLiteral("\r\n        <label  class=\"form-control\">");
                EndContext();
                BeginContext(289, 15, false);
#line 16 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                                Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(304, 54, true);
                WriteLiteral("</label>\r\n        <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 358, "\"", 382, 1);
#line 17 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 366, Model.Role.Name, 366, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(383, 47, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 430, "\"", 452, 1);
#line 18 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 438, Model.Role.Id, 438, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(453, 82, true);
                WriteLiteral(" />\r\n        \r\n\r\n    </div>\r\n    <br />\r\n    <span>Members play this role</span>\r\n");
                EndContext();
#line 24 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
     if (Model.Members.Count() == 0)
    {

#line default
#line hidden
                BeginContext(580, 68, true);
                WriteLiteral("        <div class=\"alert alert-info\">No member in this role</div>\r\n");
                EndContext();
#line 27 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(672, 289, true);
                WriteLiteral(@"        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>Remove from this role</td>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 39 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                 foreach (var item in Model.Members)
                {

#line default
#line hidden
                BeginContext(1034, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(1089, 7, false);
#line 42 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                       Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1096, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1132, 13, false);
#line 43 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                       Write(item.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1145, 108, true);
                WriteLiteral("</td>\r\n                        <td>\r\n\r\n                            <input type=\"checkbox\" name=\"IdsToRemove\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1253, "\"", 1269, 1);
#line 46 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 1261, item.Id, 1261, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1270, 63, true);
                WriteLiteral(" />\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 49 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                }

#line default
#line hidden
                BeginContext(1352, 40, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 52 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
    }

#line default
#line hidden
                BeginContext(1399, 62, true);
                WriteLiteral("\r\n    <br />\r\n    <span >Member do not play this role</span>\r\n");
                EndContext();
#line 56 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
     if (Model.NonMembers.Count() == 0)
    {

#line default
#line hidden
                BeginContext(1509, 72, true);
                WriteLiteral("        <div class=\"alert alert-info\">All members play this role</div>\r\n");
                EndContext();
#line 59 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1605, 284, true);
                WriteLiteral(@"        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>Add to this role</td>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 71 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                 foreach (var item in Model.NonMembers)
                {

#line default
#line hidden
                BeginContext(1965, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(2020, 7, false);
#line 74 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                       Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2027, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2063, 13, false);
#line 75 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                       Write(item.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(2076, 105, true);
                WriteLiteral("</td>\r\n                        <td>\r\n\r\n                            <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2181, "\"", 2197, 1);
#line 78 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 2189, item.Id, 2189, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2198, 64, true);
                WriteLiteral("  />\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 81 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
                }

#line default
#line hidden
                BeginContext(2281, 40, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 84 "C:\Users\malig\source\repos\MyApp\MyApp\Views\AdminRole\Edit.cshtml"
    }

#line default
#line hidden
                BeginContext(2328, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2334, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a266cc43a447497bb4aeca44311c9c5d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2439, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2450, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
