#pragma checksum "C:\Users\malig\source\repos\MyApp\MyApp\Views\Test\RemoveLine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf01a9aa5f268564938ed1d5f723674d8066b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_RemoveLine), @"mvc.1.0.view", @"/Views/Test/RemoveLine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/RemoveLine.cshtml", typeof(AspNetCore.Views_Test_RemoveLine))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf01a9aa5f268564938ed1d5f723674d8066b6f", @"/Views/Test/RemoveLine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"214624807db7ada68b18eda96fdd97ce43579cdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_RemoveLine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceHeader>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\malig\source\repos\MyApp\MyApp\Views\Test\RemoveLine.cshtml"
  
    ViewData["Title"] = "RemoveLine";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(115, 25, true);
            WriteLiteral("\r\n<h2>RemoveLine</h2>\r\n\r\n");
            EndContext();
            BeginContext(140, 2354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "049be53e9fd543db8d1a4742bd211f38", async() => {
                BeginContext(146, 125, true);
                WriteLiteral("\r\n    <ol id=\"lines\">\r\n        <li id=\"line1\" class=\"form-row\">\r\n\r\n            <div class=\"col form-group\">\r\n                ");
                EndContext();
                BeginContext(271, 158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec07f62783e640f69977a8bfb34b5b2f", async() => {
                    BeginContext(329, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(351, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1ef1a4756c4daf9c15b494f78b272e", async() => {
                        BeginContext(386, 7, true);
                        WriteLiteral("select ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(402, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 14 "C:\Users\malig\source\repos\MyApp\MyApp\Views\Test\RemoveLine.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Products;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(429, 397, true);
                WriteLiteral(@"
            </div>
            <div class=""col form-group"">
                <label type=""number"" class=""form-control"" />
            </div>
            <div class=""col form-group"">
                <input type=""number"" class=""form-control"" value=""1"" />
            </div>
            <div class=""col form-group"">
                <label type=""number"" class=""form-control"" data-name=""price""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 826, "\"", 852, 1);
#line 25 "C:\Users\malig\source\repos\MyApp\MyApp\Views\Test\RemoveLine.cshtml"
WriteAttributeValue("", 834, TempData["price"], 834, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(853, 531, true);
                WriteLiteral(@" />
            </div>
            <div class=""col form-group"">
                <label type=""number"" name=""total"" class=""form-control"" />
            </div>
            <div class=""col form-group"">
                <a onclick=""removeLine()"" class=""form-control btn btn-primary btn-danger btn-sm"" id=""btnRemoveLine"">remove </a>
            </div>
        </li>

    </ol>

        <div id=""newLineHtml"" >
            <li id=""qrCode"" class=""form-row"">

                <div class=""col form-group"">
                    ");
                EndContext();
                BeginContext(1384, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5334609d0fa4cae8d9c89ecc1154c4d", async() => {
                    BeginContext(1442, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(1468, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3587eb854c34087853fc18c16f7aac4", async() => {
                        BeginContext(1503, 7, true);
                        WriteLiteral("select ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1519, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 41 "C:\Users\malig\source\repos\MyApp\MyApp\Views\Test\RemoveLine.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Products;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1550, 433, true);
                WriteLiteral(@"
                </div>
                <div class=""col form-group"">
                    <label type=""number"" class=""form-control"" />
                </div>
                <div class=""col form-group"">
                    <input type=""number"" class=""form-control"" value=""1"" />
                </div>
                <div class=""col form-group"">
                    <label type=""number"" class=""form-control"" data-name=""price""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1983, "\"", 2009, 1);
#line 52 "C:\Users\malig\source\repos\MyApp\MyApp\Views\Test\RemoveLine.cshtml"
WriteAttributeValue("", 1991, TempData["price"], 1991, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2010, 477, true);
                WriteLiteral(@" />
                </div>
                <div class=""col form-group"">
                    <label type=""number"" name=""total"" class=""form-control"" />
                </div>
                <div class=""col form-group"">
                    <a  onclick=""removeLine()"" class="" btn btn-primary""  >X </a>
                </div>
            </li>
        </div>

    <div class=""form-group"">
        <a class="" btn btn-primary "" id=""btnAddline"">Addlilne </a>
    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(2494, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2517, 1702, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('document').ready(function () {

            function removeLine4() {
                alert(this.id );
                console.log($(this).attr('id'));
            };
            $('a').click(function () {
                console.log(this.id); // or alert($(this).attr('id'));
            });

        });
        function removeLine() {
            
            var result = confirm('Kayit silinsin mi?');
            if (result == true)
                $(""#qrCode"").remove();
        };

       
        function selctListChange() {
            $(""#div3"").remove();
        }
        $('document').ready(function () {
            $('#btnAddline').click(function () {
                var newLineHtml = $('#newLineHtml').html();
                $('#lines').append(newLineHtml);
               // $('ol').append('<li  class=""form-row""> ' + '  <div class=""col form-group""> < select class= ""form-control"" asp - items=""ViewBag.Products"" > <option select");
                WriteLiteral(@"ed disabled value="""">select </option> </select > </div > '+ ' < div class= ""col form-group"" > <label type=""number"" class=""form-control""></label></div > <div class=""col form-group""><input type=""number"" class=""form-control"" value=""1""></div><div class=""col form-group""><label type=""number"" class=""form-control"" data-name=""price""></label></div><div class=""col form-group""><label type=""number"" name=""total"" class=""form-control""></label></div><div class=""col form-group""><a onclick=""removeLine()"" class=""form-control btn btn-primary btn-danger btn-sm"" >  remove </a></div>     </li> ');
            });

            $('#newLineHtml').hide();


        });



    </script>
");
                EndContext();
            }
            );
            BeginContext(4222, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceHeader> Html { get; private set; }
    }
}
#pragma warning restore 1591
