#pragma checksum "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291a1d9773b0a63df66aca192b55084e94e4f695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_List), @"mvc.1.0.view", @"/Views/Suppliers/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Suppliers/List.cshtml", typeof(AspNetCore.Views_Suppliers_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291a1d9773b0a63df66aca192b55084e94e4f695", @"/Views/Suppliers/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ERP.Models.Suppliers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 388, true);
            WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <h2>List of Suppliers</h2>
    </div>
    <div class=""panel-body"">
        <table class=""table table-bordered"">
            <tr>
                <th>Company Name</th>
                <th>Point of Contact</th>
                <th>Mobile Number</th>
                <th>Email Id</th>
            </tr>
");
            EndContext();
#line 15 "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml"
             foreach (var supplier in Model)
            {

#line default
#line hidden
            BeginContext(491, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(538, 13, false);
#line 18 "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml"
                   Write(supplier.Name);

#line default
#line hidden
            EndContext();
            BeginContext(551, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(583, 23, false);
#line 19 "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml"
                   Write(supplier.PointofContact);

#line default
#line hidden
            EndContext();
            BeginContext(606, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(638, 17, false);
#line 20 "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml"
                   Write(supplier.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(655, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(687, 16, false);
#line 21 "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml"
                   Write(supplier.EmailId);

#line default
#line hidden
            EndContext();
            BeginContext(703, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 23 "D:\Projects\ERP.Web\Views\Suppliers\List.cshtml"
            }

#line default
#line hidden
            BeginContext(748, 36, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ERP.Models.Suppliers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
