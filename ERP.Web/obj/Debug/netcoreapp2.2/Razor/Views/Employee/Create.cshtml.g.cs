#pragma checksum "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87f38315d1dbba7a6cf26b85fb020921ab615a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Create.cshtml", typeof(AspNetCore.Views_Employee_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87f38315d1dbba7a6cf26b85fb020921ab615a7", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERP.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(34, 4194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87f38315d1dbba7a6cf26b85fb020921ab615a74463", async() => {
                BeginContext(100, 296, true);
                WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <h2>Add Employee</h2>
    </div>
    <div class=""panel-body"">
        <table class=""table"">
            <tbody>
                <tr>
                    <td> Enter the First Name : </td>
                    <td>");
                EndContext();
                BeginContext(397, 84, false);
#line 15 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control", maxlength = "50" }));

#line default
#line hidden
                EndContext();
                BeginContext(481, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(539, 81, false);
#line 17 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.FirstName, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(620, 156, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td> Enter the Last Name : </td>\r\n                    <td>");
                EndContext();
                BeginContext(777, 83, false);
#line 24 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control", maxlength = "50" }));

#line default
#line hidden
                EndContext();
                BeginContext(860, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(918, 80, false);
#line 26 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.LastName, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(998, 191, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td> Enter the Date Of Birth : </td>\r\n                    <td>\r\n                        <!-- ");
                EndContext();
                BeginContext(1190, 86, false);
#line 34 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                        Write(Html.TextBoxFor(m => m.DateOfBirth, new { @class = "form-control", maxlength = "50" }));

#line default
#line hidden
                EndContext();
                BeginContext(1276, 696, true);
                WriteLiteral(@" -->
                        
                        <!-- <input type=""text"" id=""datepicker""  class=""form-control""> -->
                        <div class=""form-group"">
                            <div class='input-group'>
                                <input type='text' class=""form-control datepicker"" id=""DateOfBirth"" name=""DateOfBirth"" />
                                <span class=""input-group-addon"">
                                    <span class=""glyphicon glyphicon-calendar""></span>
                                </span>
                            </div>
                        </div>
                        </td>
                    <td>
                        ");
                EndContext();
                BeginContext(1973, 83, false);
#line 47 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.DateOfBirth, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2056, 155, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n\r\n                <!-- <tr>\r\n                    <td> Enter the Gender: </td>\r\n                    <td>");
                EndContext();
                BeginContext(2212, 81, false);
#line 53 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.TextBoxFor(m => m.Gender, new { @class = "form-control", maxlength = "50" }));

#line default
#line hidden
                EndContext();
                BeginContext(2293, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2351, 78, false);
#line 55 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Gender, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2429, 1628, true);
                WriteLiteral(@"
                    </td>
                </tr> -->

                
                <tr>
                    <td> Mobile Number : </td>
                    <td> <input type=""text"" id=""MobileNo"" name=""MobileNo"" class=""form-control"" maxlength=""12""> </td>
                </tr>

                <tr>
                    <td> Enter the Email Id: </td>
                    <td> <input type=""text"" id=""Email"" name=""Email"" class=""form-control"" maxlength=""40""> </td>
                </tr>

                <tr>
                    <td> Enter the Address: </td>
                    <td> <textarea id=""Address"" name=""Address"" class=""form-control"" maxlength=""100""></textarea> </td>
                </tr>

                <tr>
                    <td> Enter Start Date : </td>
                    <td>
                        <div class=""form-group"">
                            <div class='input-group'>
                                <input type='text' class=""form-control datepicker"" id=""StartDate"" name=");
                WriteLiteral(@"""StartDate"" />
                                <span class=""input-group-addon"">
                                    <span class=""glyphicon glyphicon-calendar""></span>
                                </span>
                            </div>
                        </div>
                        </td>
                    <td>
                        
                    </td>
                </tr>

                <tr>
                    <td colspan=""2""> <input type=""Submit"" value=""Save"" class=""btn btn-success""> </td>
                </tr>
            </tbody>

        </table>
");
                EndContext();
#line 98 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
         if (!String.IsNullOrEmpty(ViewBag.Error))
        {

#line default
#line hidden
                BeginContext(4120, 44, true);
                WriteLiteral("            <div class=\"alert alert-danger\">");
                EndContext();
                BeginContext(4165, 13, false);
#line 100 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
                                       Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(4178, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 101 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Create.cshtml"
        }

#line default
#line hidden
                BeginContext(4197, 24, true);
                WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
            BeginContext(4228, 8, true);
            WriteLiteral("\r\n\r\n\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERP.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
