#pragma checksum "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9b8aca0c3c3038f6f652453cfd9140b9512e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder_Received), @"mvc.1.0.view", @"/Views/PurchaseOrder/Received.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrder/Received.cshtml", typeof(AspNetCore.Views_PurchaseOrder_Received))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9b8aca0c3c3038f6f652453cfd9140b9512e7c", @"/Views/PurchaseOrder/Received.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_Received : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseOrderDetailedView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 789, true);
            WriteLiteral(@"
<div class=""card card-default"">
    <div class=""card-header bg-success text-white"">
        Received Purchase Order Details

    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Supplier</th>
                    <th>Invoice Number</th>
                    <th>Created On</th>
                    <th>Ordered On</th>
                    <th>Received On</th>
                    <th>Total Amount</th>
                    <th>Paid Amount</th>
                    <th>Balance Amount</th>
                    <th>Fully Received</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
            EndContext();
            BeginContext(824, 8, false);
#line 26 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(832, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(864, 18, false);
#line 27 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.SupplierName);

#line default
#line hidden
            EndContext();
            BeginContext(882, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(914, 19, false);
#line 28 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.InvoiceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(933, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(965, 17, false);
#line 29 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(982, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1014, 17, false);
#line 30 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.OrderedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1063, 18, false);
#line 31 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.ReceivedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1113, 17, false);
#line 32 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1162, 16, false);
#line 33 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.PaidAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1178, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1211, 34, false);
#line 34 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                    Write(Model.TotalAmount-Model.PaidAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 36 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                         if (Model.StatusId == 5)
                        {

#line default
#line hidden
            BeginContext(1357, 114, true);
            WriteLiteral("                            <input type=\"checkbox\" class=\"form-control\" checked=\"checked\" readonly=\"readonly\" />\r\n");
            EndContext();
#line 39 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1555, 96, true);
            WriteLiteral("                            <input type=\"checkbox\" class=\"form-control\" readonly=\"readonly\" />\r\n");
            EndContext();
#line 43 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                        }

#line default
#line hidden
            BeginContext(1678, 644, true);
            WriteLiteral(@"                    </td>
                </tr>
            </tbody>
        </table>

        <div class=""row""><div class=""col-md"">&nbsp;</div></div>

    </div>
</div>
<p>&nbsp;</p>
<div class=""card card-default"">

    <div class=""card-header bg-success text-white"">
        Items
    </div>
    <div class=""card-body"">

        <table class=""table table-bordered tablePOItems"">
            <thead>
                <tr>
                    <th>Material</th>
                    <th>Ordered Quantity</th>
                    <th>Received Quantity</th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 71 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
            BeginContext(2393, 113, true);
            WriteLiteral("                    <tr class=\"trReceiveItems\">\r\n                        <td>\r\n                            <span>");
            EndContext();
            BeginContext(2507, 17, false);
#line 75 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                             Write(item.MaterialName);

#line default
#line hidden
            EndContext();
            BeginContext(2524, 69, true);
            WriteLiteral("</span>\r\n                            <input type=\"hidden\" id=\"itemId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2593, "\"", 2609, 1);
#line 76 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
WriteAttributeValue("", 2601, item.Id, 2601, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2610, 69, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"materialId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2679, "\"", 2703, 1);
#line 77 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
WriteAttributeValue("", 2687, item.MaterialId, 2687, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2704, 90, true);
            WriteLiteral(" />\r\n                        </td>\r\n                        <td class=\"tdOrderedQuantity\">");
            EndContext();
            BeginContext(2795, 20, false);
#line 79 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                                                 Write(item.OrderedQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2815, 61, true);
            WriteLiteral("</td>\r\n                        <td class=\"tdOrderedQuantity\">");
            EndContext();
            BeginContext(2877, 21, false);
#line 80 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                                                 Write(item.ReceivedQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2898, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 82 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                }

#line default
#line hidden
            BeginContext(2951, 716, true);
            WriteLiteral(@"            </tbody>
        </table>

    </div>
</div>
<p>&nbsp;</p>
<div class=""card card-default"">

    <div class=""card-header bg-success text-white"">
        Payments to Supplier
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""card card-default bg-light divAddSupplierPayment"">
                    <div class=""card-header"">Add New payment</div>
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label>Payment Menthod</label>
                            <select id=""ddlPaymentOptions"" class=""form-control"">
                                ");
            EndContext();
            BeginContext(3667, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9b8aca0c3c3038f6f652453cfd9140b9512e7c14007", async() => {
                BeginContext(3685, 4, true);
                WriteLiteral("Cash");
                EndContext();
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
            EndContext();
            BeginContext(3698, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3732, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9b8aca0c3c3038f6f652453cfd9140b9512e7c15415", async() => {
                BeginContext(3750, 6, true);
                WriteLiteral("Cheque");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3765, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3799, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9b8aca0c3c3038f6f652453cfd9140b9512e7c16825", async() => {
                BeginContext(3817, 12, true);
                WriteLiteral("BankTransfer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3838, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3872, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9b8aca0c3c3038f6f652453cfd9140b9512e7c18242", async() => {
                BeginContext(3890, 11, true);
                WriteLiteral("PointOfSale");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3910, 2634, true);
            WriteLiteral(@"
                            </select>

                        </div>
                        <div class=""form-group"">
                            <label>Enter Amount</label>
                            <input type=""text"" class=""form-control txtAddAmount"" maxlength=""10"" />
                        </div>
                        <div class=""form-group"">
                            <label>Date/Time</label>
                            <div class=""form-group"">
                                <div class=""input-group date datetimepicker2"" id=""datetimepicker1"" data-target-input=""nearest"">
                                    <input type=""text"" id=""paidDate"" name=""paidDate"" class=""form-control datetimepicker-input"" data-target=""#datetimepicker1"" />
                                    <div class=""input-group-append"" data-target=""#datetimepicker1"" data-toggle=""datetimepicker"">
                                        <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                       ");
            WriteLiteral(@"             </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer"">
                        <input type=""button"" class=""btn btn-success btnAddPayment"" value=""Save"" />
                    </div>

                </div>
            </div>
        </div>
        <div class=""row""><p>&nbsp;</p></div>
        <div class=""row"">
            <div class=""col-md-6"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr class=""bg-light"">
                            <th>Date/Time</th>
                            <th>Amount Paid</th>
                            <th>Payment Type</th>
                            <th>Added By</th>
                        </tr>
                    </thead>
                    <tbody class=""tbodySupplierPayments""></tbody>
                </table>
            </div>
        </div>
     ");
            WriteLiteral(@"   <div class=""row""><p>&nbsp;</p></div>
        <div class=""row"">
            <div class=""col-md-6"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr class=""bg-light"">
                            <th>Event Type</th>
                            <th>Date/Time</th>
                            <th>Added By</th>
                        </tr>
                    </thead>
                    <tbody class=""tbodyEvents""></tbody>
                </table>
            </div>
        </div>
    </div>
    
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6561, 193, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        getPayments();\r\n        getEvents();\r\n        function getPayments() {\r\n            \r\n            let url = \'");
                EndContext();
                BeginContext(6755, 49, false);
#line 175 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                  Write(Url.Action("GetSupplierPayments","PurchaseOrder"));

#line default
#line hidden
                EndContext();
                BeginContext(6804, 9, true);
                WriteLiteral("\' + \'/\' +");
                EndContext();
                BeginContext(6814, 8, false);
#line 175 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                                                                             Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(6822, 1289, true);
                WriteLiteral(@";
            console.log('Attempting to get payments! '+url);
            $.ajax({
                    type: 'GET',
                    url: url
                })
                .done(function (data) {
                    // show the response
                    console.log('payments data'+JSON.stringify(data));
                    populatePayments(data);
                });
        }

        function populatePayments(data) {
            $('.tbodySupplierPayments').html('');
            if (data) {
                        $.each(data, function (index, value) {
                            console.log('Payments: ' + JSON.stringify(value));
                            $('.tbodySupplierPayments').append(""<tr><td>"" + value.timestamp + ""</td><td>"" + value.amount +  ""</td><td>"" + getPaymentType(value.paymentTypeId) + ""</td><td>"" + value.addedBy + ""</td></tr>"");
                            
                        });
                    }
                    //if (data.length === 0) {
    ");
                WriteLiteral(@"                //    console.log('no payments');
                    //    $('.tableCustomerPayments').hide();
                    //}
        }

        $("".btnAddPayment"").click(function () {
            let newPayment = {
                PurchaseOrderId:");
                EndContext();
                BeginContext(8112, 8, false);
#line 205 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                           Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(8120, 258, true);
                WriteLiteral(@",
                Amount: $("".txtAddAmount"").val(),
                PaymentTypeId: $(""#ddlPaymentOptions"").val(),
                Timestamp:$(""#paidDate"").val()
            };

            $.ajax({
                type: 'POST',
                url: '");
                EndContext();
                BeginContext(8379, 32, false);
#line 213 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                 Write(Url.Action("AddSupplierPayment"));

#line default
#line hidden
                EndContext();
                BeginContext(8411, 1039, true);
                WriteLiteral(@"',
                data: JSON.stringify(newPayment),
                contentType: ""application/json;""
            })
                .done(function (data) {
                    // show the response
                    if (data) {
                        //getPayments();
                        location.reload();
                    }
                });
        });

        function getPaymentType(paymentTypeId) {
            let paymentType = '';
            switch (paymentTypeId) {
                case 1:
                    paymentType = 'Cash';
                    break;
                case 2:
                    paymentType = 'Cheque';
                    break;
                case 3:
                    paymentType = 'Bank Transfer';
                    break;
                case 4:
                    paymentType = 'Point of Sale';
                    break;
            }
            return paymentType;
        }

        function getEvents() {
            
        ");
                WriteLiteral("    let url = \'");
                EndContext();
                BeginContext(9451, 39, false);
#line 247 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                  Write(Url.Action("GetEvents","PurchaseOrder"));

#line default
#line hidden
                EndContext();
                BeginContext(9490, 9, true);
                WriteLiteral("\' + \'/\' +");
                EndContext();
                BeginContext(9500, 8, false);
#line 247 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                                                                   Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(9508, 740, true);
                WriteLiteral(@";
            console.log('Attempting to get events! '+url);
            $.ajax({
                    type: 'GET',
                    url: url
                })
                .done(function (data) {
                    // show the response
                    console.log('events data'+JSON.stringify(data));
                    $.each(data, function (index, value) {
                            console.log('Events: ' + JSON.stringify(value));
                            $('.tbodyEvents').append(""<tr><td>"" + value.eventType + ""</td><td>"" + value.timestamp +  ""</td><td>"" + value.addedBy + ""</td></tr>"");
                            
                        });
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurchaseOrderDetailedView> Html { get; private set; }
    }
}
#pragma warning restore 1591
