#pragma checksum "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7c3853d617039672fc2aa73898179078a136b64"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7c3853d617039672fc2aa73898179078a136b64", @"/Views/PurchaseOrder/Received.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_Received : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseOrderDetailedView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 653, true);
            WriteLiteral(@"
<div class=""card card-default"">
    <div class=""card-header"">
        Received Purchase Order Details
        
        
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Supplier</th>
                    <th>Created On</th>
                    <th>Ordered On</th>
                    <th>Received On</th>
                    <th>Total Amount</th>
                    <th>Fully Received</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
            EndContext();
            BeginContext(688, 8, false);
#line 24 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(696, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(728, 18, false);
#line 25 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.SupplierName);

#line default
#line hidden
            EndContext();
            BeginContext(746, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(778, 17, false);
#line 26 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(795, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(827, 17, false);
#line 27 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.OrderedDate);

#line default
#line hidden
            EndContext();
            BeginContext(844, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(876, 18, false);
#line 28 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.ReceivedDate);

#line default
#line hidden
            EndContext();
            BeginContext(894, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(926, 17, false);
#line 29 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                   Write(Model.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(943, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 31 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                         if(Model.StatusId==5){

#line default
#line hidden
            BeginContext(1025, 110, true);
            WriteLiteral("                        <input type=\"checkbox\" class=\"form-control\" checked=\"checked\" readonly=\"readonly\" />\r\n");
            EndContext();
#line 33 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                        }
                        else{

#line default
#line hidden
            BeginContext(1193, 92, true);
            WriteLiteral("                        <input type=\"checkbox\" class=\"form-control\" readonly=\"readonly\" />\r\n");
            EndContext();
#line 36 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                        }                        

#line default
#line hidden
            BeginContext(1336, 688, true);
            WriteLiteral(@"                    </td>
                </tr>
            </tbody>
        </table>
        
        <div class=""row""><div class=""col-md"">&nbsp;</div></div>
        
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
                    <th>Received Quantity</th>
                </tr>
            </thead>
            <tbody>
                
");
            EndContext();
#line 64 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
            BeginContext(2095, 107, true);
            WriteLiteral("                    <tr class=\"trReceiveItems\">                        \r\n                        <td><span>");
            EndContext();
            BeginContext(2203, 17, false);
#line 67 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                             Write(item.MaterialName);

#line default
#line hidden
            EndContext();
            BeginContext(2220, 70, true);
            WriteLiteral("</span> \r\n                            <input type=\"hidden\" id=\"itemId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2290, "\"", 2306, 1);
#line 68 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
WriteAttributeValue("", 2298, item.Id, 2298, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2307, 70, true);
            WriteLiteral(" /> \r\n                            <input type=\"hidden\" id=\"materialId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2377, "\"", 2401, 1);
#line 69 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
WriteAttributeValue("", 2385, item.MaterialId, 2385, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2402, 91, true);
            WriteLiteral(" /> \r\n                        </td>\r\n                        <td class=\"tdOrderedQuantity\">");
            EndContext();
            BeginContext(2494, 20, false);
#line 71 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                                                 Write(item.OrderedQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2514, 61, true);
            WriteLiteral("</td>\r\n                        <td class=\"tdOrderedQuantity\">");
            EndContext();
            BeginContext(2576, 21, false);
#line 72 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                                                 Write(item.ReceivedQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2597, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 74 "D:\Projects\ERP.Web\Views\PurchaseOrder\Received.cshtml"
                }

#line default
#line hidden
            BeginContext(2650, 68, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurchaseOrderDetailedView> Html { get; private set; }
    }
}
#pragma warning restore 1591
