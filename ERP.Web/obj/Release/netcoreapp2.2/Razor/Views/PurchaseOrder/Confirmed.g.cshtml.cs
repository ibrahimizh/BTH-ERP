#pragma checksum "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4d6093e525f3f8e3ef8d84417dedb41aabe418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder_Confirmed), @"mvc.1.0.view", @"/Views/PurchaseOrder/Confirmed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrder/Confirmed.cshtml", typeof(AspNetCore.Views_PurchaseOrder_Confirmed))]
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
#line 1 "D:\Projects\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Web;

#line default
#line hidden
#line 2 "D:\Projects\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#line 4 "D:\Projects\ERP.Web\Views\_ViewImports.cshtml"
using ERP.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4d6093e525f3f8e3ef8d84417dedb41aabe418", @"/Views/PurchaseOrder/Confirmed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_Confirmed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseOrderDetailedView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input  confirmPO hide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chkPartiallyReceived"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "txtReceivedItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control txtReceivedItems"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtTotalAmount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 514, true);
            WriteLiteral(@"
<div class=""card card-default"">
    <div class=""card-header"">
        Purchase Order Details
        
        
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Supplier</th>
                    <th>Created On</th>
                    <th>Ordered On</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
            EndContext();
            BeginContext(549, 8, false);
#line 21 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(557, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(589, 18, false);
#line 22 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                   Write(Model.SupplierName);

#line default
#line hidden
            EndContext();
            BeginContext(607, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(639, 17, false);
#line 23 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                   Write(Model.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(656, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(688, 17, false);
#line 24 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                   Write(Model.OrderedDate);

#line default
#line hidden
            EndContext();
            BeginContext(705, 634, true);
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
        <div class=""row"">
            <div class=""col-md-2"">
                <button class=""btn btn-success"" id=""btnReceivePO"" type=""button"" >Receive</button>
            </div>
            <div class=""col-md-2"">
                <button class=""btn btn-default confirmPO hide"" id=""btnCancelReceivePO"" >Cancel</button>
            </div>
        </div>
        <div class=""row""><div class=""col-md"">&nbsp;</div></div>
        <div class=""row"">
            <div class=""col-md-2"">
                <div class=""form-check confirmPO hide"">
                    ");
            EndContext();
            BeginContext(1339, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c4d6093e525f3f8e3ef8d84417dedb41aabe4189313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 40 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PartiallyReceived);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1464, 752, true);
            WriteLiteral(@"
                    <label class=""form-check-label"" for=""defaultCheck1"">
                        Items Partially Received
                    </label>
                </div>
            </div>
        </div>
    </div>
</div>
<br />
<div class=""card card-default"">
    
    <div class=""card-header"">
        <h3>Items</h3>
    </div>
    <div class=""card-body"">
        
        <table class=""table table-bordered tablePOItems"">
            <thead>
                <tr>                    
                    <th>Material</th>
                    <th>Ordered Quantity</th>
                    <th class=""confirmPO hide"">Received Quantity</th>
                </tr>
            </thead>
            <tbody>
                
");
            EndContext();
#line 67 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
            BeginContext(2287, 107, true);
            WriteLiteral("                    <tr class=\"trReceiveItems\">                        \r\n                        <td><span>");
            EndContext();
            BeginContext(2395, 17, false);
#line 70 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                             Write(item.MaterialName);

#line default
#line hidden
            EndContext();
            BeginContext(2412, 70, true);
            WriteLiteral("</span> \r\n                            <input type=\"hidden\" id=\"itemId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2482, "\"", 2498, 1);
#line 71 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
WriteAttributeValue("", 2490, item.Id, 2490, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2499, 70, true);
            WriteLiteral(" /> \r\n                            <input type=\"hidden\" id=\"materialId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2569, "\"", 2593, 1);
#line 72 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
WriteAttributeValue("", 2577, item.MaterialId, 2577, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2594, 91, true);
            WriteLiteral(" /> \r\n                        </td>\r\n                        <td class=\"tdOrderedQuantity\">");
            EndContext();
            BeginContext(2686, 20, false);
#line 74 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                                                 Write(item.OrderedQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2706, 218, true);
            WriteLiteral("</td>\r\n                        <td class=\"confirmPO hide tdReceivedQuantity\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-3\">\r\n                                    ");
            EndContext();
            BeginContext(2924, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c4d6093e525f3f8e3ef8d84417dedb41aabe41814263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 78 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.ReceivedQuantity);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "max", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 78 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
AddHtmlAttributeValue("", 3051, item.OrderedQuantity, 3051, 21, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3076, 136, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 83 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                }

#line default
#line hidden
            BeginContext(3231, 227, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"confirmPO hide\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-2\">Total Amount</div>\r\n                <div class=\"col-md-2\">\r\n                    ");
            EndContext();
            BeginContext(3458, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c4d6093e525f3f8e3ef8d84417dedb41aabe41817164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 90 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TotalAmount);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3568, 300, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-2"">
                    <button class=""btn btn-success"" id=""btnConfirmReceive"">Confirm Receive</button>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3885, 1005, true);
                WriteLiteral(@"
    <script>
    $(document).ready(function(){
        $(""#btnReceivePO"").click(function(){
            $("".confirmPO"").removeClass(""hide"").addClass(""show"");
        });

        $(""#chkPartiallyReceived"").click(function(){
            if($(""#chkPartiallyReceived""). prop(""checked"") == true)
            {
                $('.txtReceivedItems').prop(""disabled"", false);
            }
            else{
                $('.txtReceivedItems').prop(""disabled"", true);
            }
        });

        $(""#btnConfirmReceive"").click(function(e){
            e.preventDefault();
            var total=$(""#txtTotalAmount"").val();
            if(total)
            {
                if(parseFloat(total)<0.1)
                {
                    alert(""Enter valid Amount!"");
                }
                else{
                    var isPartiallyReceived=$(""#chkPartiallyReceived""). prop(""checked"");
                    var purchaseOrderReceived={
                        id:");
                EndContext();
                BeginContext(4891, 8, false);
#line 131 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                      Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(4899, 1157, true);
                WriteLiteral(@",
                        partiallyReceived:isPartiallyReceived,
                        totalAmount:total,
                        items:[]
                    };

                    $('.trReceiveItems').each(function () {
                            var item = $(this); //this should represent one row
                            var itemId=item.find('input:hidden[id=itemId]').val();
                            var materialId=item.find('input:hidden[id=materialId]').val();
                            var receivedItemQuantity=0;
                            if(isPartiallyReceived)
                            {
                                receivedItemQuantity= item.find('input[name=txtReceivedItems]').val();
                            }
                            else{
                                receivedItemQuantity = item.find('.tdOrderedQuantity').text();
                            }
                            purchaseOrderReceived.items.push({id:itemId,receivedQuantity:received");
                WriteLiteral("ItemQuantity,materialId:materialId});\r\n                            \r\n                    });\r\n\r\n                    var redirectUrl=\'");
                EndContext();
                BeginContext(6057, 40, false);
#line 153 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                                Write(Url.Action("Received",new{id=@Model.Id}));

#line default
#line hidden
                EndContext();
                BeginContext(6097, 105, true);
                WriteLiteral("\';\r\n\r\n                    $.ajax({\r\n                        type: \'POST\',\r\n                        url: \'");
                EndContext();
                BeginContext(6203, 21, false);
#line 157 "D:\Projects\ERP.Web\Views\PurchaseOrder\Confirmed.cshtml"
                         Write(Url.Action("Receive"));

#line default
#line hidden
                EndContext();
                BeginContext(6224, 695, true);
                WriteLiteral(@"', 
                        data: JSON.stringify(purchaseOrderReceived),
                        contentType: ""application/json;"",
                    })
                    .done(function(data){ 
                        alert(""Success: Purchase Order updated!"");
                        window.location=redirectUrl;               
                    })
                    .fail(function ( jqXHR, textStatus, errorThrown ) {
                        alert(""Error updating Purchase Order!"");
                    });
                }
            }
            else{
                alert(""Enter Total Amount!"");
            }
            

        });
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
