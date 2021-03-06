#pragma checksum "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\WorkOrder\PaymentReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8feb1d39d74ac212c61a6b8b7af3cdb58963e57a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOrder_PaymentReport), @"mvc.1.0.view", @"/Views/WorkOrder/PaymentReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOrder/PaymentReport.cshtml", typeof(AspNetCore.Views_WorkOrder_PaymentReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8feb1d39d74ac212c61a6b8b7af3cdb58963e57a", @"/Views/WorkOrder/PaymentReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOrder_PaymentReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\WorkOrder\PaymentReport.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Payment Report";

#line default
#line hidden
            BeginContext(97, 12, true);
            WriteLiteral("    \r\n\r\n    ");
            EndContext();
            BeginContext(109, 6383, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8feb1d39d74ac212c61a6b8b7af3cdb58963e57a4168", async() => {
                BeginContext(134, 6351, true);
                WriteLiteral(@"
        <div class=""card"">
            <div class=""card-header bg-primary text-white""><h6 class=""card-title"">Customer Payments - Report</h6></div>
            <div class=""card-body"">
                <div class=""card"">
                    <div class=""card-header bg-info text-white"">
                        <h6>Filter</h6>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <table class=""table table-bordered"">
                                    <tbody>

                                        <tr>
                                            <td class=""bg-light""><label>Customer Name</label></td>
                                            <td><input type=""text"" class=""form-control"" id=""txtCustomerName"" /></td>
                                        </tr>
                                        <tr>
                                            <td cla");
                WriteLiteral(@"ss=""bg-light""><label>Contact Name</label></td>
                                            <td><input type=""text"" class=""form-control"" id=""txtContactName"" /></td>
                                        </tr>
                                        <tr>
                                            <td class=""bg-light""><label>Paid On</label></td>
                                            <td>
                                                <div class=""form-group"">
                                                    <div class='input-group'>
                                                        <input type='text' class=""form-control datepicker"" id=""dtCreatedOn"" />
                                                        <span class=""input-group-addon"">
                                                            <span class=""glyphicon glyphicon-calendar""></span>
                                                        </span>
                                                    </div>
              ");
                WriteLiteral(@"                                  </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class=""bg-light""><label>Payments From</label></td>
                                            <td>
                                                <div class=""form-group"">
                                                    <div class='input-group'>
                                                        <input type='text' class=""form-control datepicker"" id=""dtCreatedFrom"" />
                                                        <span class=""input-group-addon"">
                                                            <span class=""glyphicon glyphicon-calendar""></span>
                                                        </span>
                                                    </div>
                                                </div>
                      ");
                WriteLiteral(@"                      </td>
                                        </tr>
                                        <tr>
                                            <td class=""bg-light""><label>Payments To</label></td>
                                            <td>
                                                <div class=""form-group"">
                                                    <div class='input-group'>
                                                        <input type='text' class=""form-control datepicker"" id=""dtCreatedTo"" />
                                                        <span class=""input-group-addon"">
                                                            <span class=""glyphicon glyphicon-calendar""></span>
                                                        </span>
                                                    </div>
                                                </div>
                                            </td>
                                       ");
                WriteLiteral(@" </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>

                    </div>
                    <div class=""card-footer"">
                        <input id=""btnSearch"" type=""button"" class=""btn btn-success"" value=""Search"" />
                    </div>
                </div>
                <p>&nbsp;</p>
                <div class=""card"">
                    <div class=""card-header bg-success text-white""><h6 class=""card-title"">Results</h6></div>
                    <div class=""card-body"">

                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""reportSummary col-md-4""></div>
                            </div>
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr class=""bg-info text-white"">

                  ");
                WriteLiteral(@"                      <th>
                                            Date
                                        </th>
                                        <th>
                                            Receipt No
                                        </th>
                                        <th>
                                            Customer Name
                                        </th>
                                        <th>
                                            Contact Person
                                        </th>
                                        <th>
                                            Payment Type
                                        </th>
                                        <th>
                                            Amount
                                        </th>
                                    </tr>
                                </thead>
                                <tbody class=""tbodyReport"">
   ");
                WriteLiteral("                             </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(6492, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6517, 1002, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#btnSearch').click(function () {
                let customerName = $('#txtCustomerName').val();
                let contactName = $('#txtContactName').val();
                let dtCreatedOn = $('#dtCreatedOn').val();
                let dtCreatedFrom = $('#dtCreatedFrom').val();
                let dtCreatedTo = $('#dtCreatedTo').val();
                let mobileNo = $('#txtMobile').val();

                let searchModel = {
                    ""CustomerName"": customerName,
                    ""ContactName"": contactName,
                    ""Date"":dtCreatedOn,
                    ""DateFrom"": dtCreatedFrom,
                    ""DateTo"": dtCreatedTo,
                    ""mobileNo"":mobileNo
                };
                console.log(""Search Model: "" + JSON.stringify(searchModel));
                $.ajax({
                        type: 'POST',
                        url: '");
                EndContext();
                BeginContext(7520, 38, false);
#line 148 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\WorkOrder\PaymentReport.cshtml"
                         Write(Url.Action("GetFilteredPaymentReport"));

#line default
#line hidden
                EndContext();
                BeginContext(7558, 1640, true);
                WriteLiteral(@"',
                        data: JSON.stringify(searchModel),
                        contentType: ""application/json;""
                    })
                        .done(function (data) {
                            console.log(JSON.stringify(data));
                            $('.tbodyReport').html('');
                            $('.reportSummary').html('');
                            for (i = 0; i < data.reportData.length; i++) {
                                $('.tbodyReport').append(""<tr><td>"" + reviver(data.reportData[i].dateString) + ""</td><td>"" + data.reportData[i].receiptNumber + ""</td><td>"" + data.reportData[i].customerName + ""</td><td>"" + data.reportData[i].contactDisplayName + ""</td><td>"" + data.reportData[i].paymentType + ""</td><td>"" + data.reportData[i].amount + ""</td></tr>"");
                            }
                            $('.reportSummary').html(""<h6>Summary</h6><table class='table table-borderless'><tr><td class='bg-light'>Cash</td><td>""+data.cashTotal+""</td></tr><");
                WriteLiteral(@"tr><td class='bg-light'>Bank Transfer</td><td>""+data.bankTransferTotal+""</td></tr><tr><td class='bg-light'>Cheque</td><td>""+data.chequeTotal+""</td></tr><tr><td class='bg-light'>Point Of Sale</td><td>""+data.pointOfSaleTotal+""</td></tr></table>"");
                        });
            });

            const dateFormat = /^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$/;

            function reviver(value) {
              if (typeof value === ""string"" && dateFormat.test(value)) {
                return new Date(value);
              }
              return value;
            }

        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
