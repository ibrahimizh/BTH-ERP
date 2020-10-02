#pragma checksum "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\SupplierPaymentsReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f81583f4fec8cc550564c0dca733c2724c4eb52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder_SupplierPaymentsReport), @"mvc.1.0.view", @"/Views/PurchaseOrder/SupplierPaymentsReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrder/SupplierPaymentsReport.cshtml", typeof(AspNetCore.Views_PurchaseOrder_SupplierPaymentsReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f81583f4fec8cc550564c0dca733c2724c4eb52", @"/Views/PurchaseOrder/SupplierPaymentsReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_SupplierPaymentsReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 5283, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f81583f4fec8cc550564c0dca733c2724c4eb523934", async() => {
                BeginContext(25, 5251, true);
                WriteLiteral(@"
    <div class=""card"">
        <div class=""card-header""><h6 class=""card-title"">Supplier Payments Report</h6></div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""card"">
                        <div class=""card-header"">Filter</div>
                        <div class=""card-body bg-light"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <table class=""table table-bordered"">
                                        <tbody>
                                            <tr>
                                                <td class=""bg-light""><label>Paid On</label></td>
                                                <td>
                                                    <div class=""form-group"">
                                                        <div class='input-group'>
                                                  ");
                WriteLiteral(@"          <input type='text' class=""form-control datepicker"" id=""dtCreatedOn"" />
                                                            <span class=""input-group-addon"">
                                                                <span class=""glyphicon glyphicon-calendar""></span>
                                                            </span>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class=""bg-light""><label>Payments From</label></td>
                                                <td>
                                                    <div class=""form-group"">
                                                        <div class='input-group'>
                                                            <inp");
                WriteLiteral(@"ut type='text' class=""form-control datepicker"" id=""dtCreatedFrom"" />
                                                            <span class=""input-group-addon"">
                                                                <span class=""glyphicon glyphicon-calendar""></span>
                                                            </span>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class=""bg-light""><label>Payments To</label></td>
                                                <td>
                                                    <div class=""form-group"">
                                                        <div class='input-group'>
                                                            <input type='text'");
                WriteLiteral(@" class=""form-control datepicker"" id=""dtCreatedTo"" />
                                                            <span class=""input-group-addon"">
                                                                <span class=""glyphicon glyphicon-calendar""></span>
                                                            </span>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <input id=""btnSearch"" type=""button"" class=""btn btn-success"" value=""Search"" />
                        </div>
                    </div>
                </div>
            </d");
                WriteLiteral(@"iv>
            
            <p>&nbsp;</p>
            <div class=""card"">
                <div class=""card-header"">Results</div>
                <div class=""card-body"">
                    <div class=""row"">
                        <h5 class=""text-danger""><span class=""lblTotal card-title""></span></h5>
                    </div>
                    <div class=""row"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr class=""bg-light"">
                                    <th>Timestamp</th>
                                    <th>PurchaseOrderId</th>
                                    <th>SupplierName</th>
                                    <th>PaymentType</th>
                                    <th>InvoiceNo</th>
                                    <th>Amount</th>
                                </tr>
                            </thead>
                            <tbody class=""tbodyReport""></tbody>
       ");
                WriteLiteral("                 </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(5283, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5306, 695, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#btnSearch').click(function () {
                
                let dtCreatedOn = $('#dtCreatedOn').val();
                let dtCreatedFrom = $('#dtCreatedFrom').val();
                let dtCreatedTo = $('#dtCreatedTo').val();

                let searchModel = {
                    ""Date"":dtCreatedOn,
                    ""DateFrom"": dtCreatedFrom,
                    ""DateTo"": dtCreatedTo
                };
                console.log(""Search Model: "" + JSON.stringify(searchModel));
                $.ajax({
                        type: 'POST',
                        url: '");
                EndContext();
                BeginContext(6002, 39, false);
#line 113 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\SupplierPaymentsReport.cshtml"
                         Write(Url.Action("GetSupplierPaymentsReport"));

#line default
#line hidden
                EndContext();
                BeginContext(6041, 1532, true);
                WriteLiteral(@"',
                        data: JSON.stringify(searchModel),
                        contentType: ""application/json;""
                    })
                        .done(function (data) {
                            console.log(JSON.stringify(data));
                            $('.tbodyReport').html('');
                            $('.lblTotal').text('');
                            if (data.length === 0) {
                                $('.lblTotal').text('No results!');
                            } else {
                                let total = 0;
                                $.each(data, function (index, payment) {
                                    $('.tbodyReport').append(""<tr><td>"" + payment.timestamp + ""</td><td>"" + payment.purchaseOrderId + ""</td><td>"" + payment.supplierName + ""</td><td>"" + payment.paymentType + ""</td><td>"" + payment.invoiceNo + ""</td><td>"" + payment.amount + ""</td></tr>"");
                                    total = total + payment.amount;
              ");
                WriteLiteral(@"                  });
                                $('.lblTotal').text(""Total : "" + total.toFixed(2));
                            }
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