#pragma checksum "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10177ce5b58cb7b168209b11e3ac04d5a5bbd9f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materials_Create), @"mvc.1.0.view", @"/Views/Materials/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Materials/Create.cshtml", typeof(AspNetCore.Views_Materials_Create))]
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
#line 1 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Web;

#line default
#line hidden
#line 2 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#line 4 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10177ce5b58cb7b168209b11e3ac04d5a5bbd9f4", @"/Views/Materials/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Materials_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERP.Models.Materials>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Materials", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(35, 1649, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10177ce5b58cb7b168209b11e3ac04d5a5bbd9f44472", async() => {
                BeginContext(102, 266, true);
                WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <h2>Add Material</h2>
    </div>
    <div class=""panel-body"">
        <table class=""table"">
    <tbody>
        <tr>
            <td> Enter the Product Code : </td>
            <td>");
                EndContext();
                BeginContext(369, 70, false);
#line 15 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
           Write(Html.TextBoxFor(m=>m.Code,new {@class="form-control", maxlength="50"}));

#line default
#line hidden
                EndContext();
                BeginContext(439, 41, true);
                WriteLiteral("</td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(481, 68, false);
#line 17 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
           Write(Html.ValidationMessageFor(m=>m.Code,null,new {@class="text-danger"}));

#line default
#line hidden
                EndContext();
                BeginContext(549, 222, true);
                WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n            <td> Enter the Product Name : </td>\r\n            <td> <input type=\"text\" id=\"Name\" name=\"Name\" class=\"form-control\" maxlength=\"100\"> </td>\r\n            <td>");
                EndContext();
                BeginContext(772, 68, false);
#line 25 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
           Write(Html.ValidationMessageFor(m=>m.Name,null,new {@class="text-danger"}));

#line default
#line hidden
                EndContext();
                BeginContext(840, 417, true);
                WriteLiteral(@"</td>      
        </tr>

        <tr>
            <td> Description  : </td>
            <td> <textarea id=""Specification"" name=""Specification"" class=""form-control"" maxlength=""100""></textarea></td>
        </tr>

        <tr>
            <td> Enter the Shelf Number : </td>
            <td> <input type=""text"" id=""ShelfNumber"" name=""ShelfNumber"" class=""form-control"" maxlength=""30""> </td>
            <td>");
                EndContext();
                BeginContext(1258, 83, false);
#line 36 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.ShelfNumber, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1341, 174, true);
                WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td colspan=\"2\"> <input type=\"Submit\" value=\"Save\" class=\"btn btn-success\"> </td>\r\n        </tr>\r\n    </tbody>\r\n\r\n</table>\r\n");
                EndContext();
#line 45 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
         if (!String.IsNullOrEmpty(ViewBag.Error))
        {

#line default
#line hidden
                BeginContext(1578, 44, true);
                WriteLiteral("            <div class=\"alert alert-danger\">");
                EndContext();
                BeginContext(1623, 13, false);
#line 47 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
                                       Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(1636, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 48 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Materials\Create.cshtml"
        }

#line default
#line hidden
                BeginContext(1655, 22, true);
                WriteLiteral("    </div>\r\n</div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERP.Models.Materials> Html { get; private set; }
    }
}
#pragma warning restore 1591
