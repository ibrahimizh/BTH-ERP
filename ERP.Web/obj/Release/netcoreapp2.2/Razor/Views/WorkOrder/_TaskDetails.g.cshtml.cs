#pragma checksum "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a996ef8e63bb381792b76a7fb05a47f7e429d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOrder__TaskDetails), @"mvc.1.0.view", @"/Views/WorkOrder/_TaskDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOrder/_TaskDetails.cshtml", typeof(AspNetCore.Views_WorkOrder__TaskDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a996ef8e63bb381792b76a7fb05a47f7e429d3f", @"/Views/WorkOrder/_TaskDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOrder__TaskDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkOrderTaskView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 123, true);
            WriteLiteral("\r\n\r\n<div class=\"card shadow-lg p-3 mb-5 bgDefault rounded\">\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">");
            EndContext();
            BeginContext(150, 17, false);
#line 6 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(167, 181, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card-body\" style=\"font-size:10px !important;\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h6>Assigned to : ");
            EndContext();
            BeginContext(349, 18, false);
#line 11 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                             Write(Model.EmployeeName);

#line default
#line hidden
            EndContext();
            BeginContext(367, 140, true);
            WriteLiteral("</h6>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h6>Target Date: ");
            EndContext();
            BeginContext(508, 16, false);
#line 16 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                            Write(Model.TargetDate);

#line default
#line hidden
            EndContext();
            BeginContext(524, 309, true);
            WriteLiteral(@"</h6>
            </div>
        </div>
        <!-- <div class=""row"">
            <div class=""col-md-12"">
                <h6>Status</h6>
                <select id=""ddlTaskStatus"" class=""form-control"" asp-items=""Html.GetEnumSelectList<WorkOrderTaskStatus>()""
                                asp-for=""");
            EndContext();
            BeginContext(834, 14, false);
#line 23 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                                    Write(Model.StatusId);

#line default
#line hidden
            EndContext();
            BeginContext(848, 226, true);
            WriteLiteral("\"></select>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h6>Progress (%)</h6>\r\n                <input id=\"txtTaskProgress\" class=\"form-control\" asp-for=\"");
            EndContext();
            BeginContext(1075, 14, false);
#line 29 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                                                                     Write(Model.Progress);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 46, true);
            WriteLiteral("\" />\r\n            </div>\r\n        </div> -->\r\n");
            EndContext();
#line 32 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
         if(Model.CompletedDate==null){

#line default
#line hidden
            BeginContext(1176, 325, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">
                <h6>Completed Date-Time</h6>
                <!-- <div class=""form-group"">
                    <div class=""input-group date datetimepicker"" id=""datetimepicker1"" data-target-input=""nearest"">
                        <input type=""text"" asp-for=""");
            EndContext();
            BeginContext(1502, 19, false);
#line 38 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                                               Write(Model.CompletedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 1560, true);
            WriteLiteral(@""" class=""form-control datetimepicker datetimepicker-input txtTaskCompletedDate""  data-target=""#datetimepicker1"" />
                        <div class=""input-group-append"" data-target=""#datetimepicker1"" data-toggle=""datetimepicker"">
                            <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                        </div>
                    </div>
                </div> -->
                <div class=""row text-danger"">
                    <div class=""col-xs-2 textBox2ch""><h6>DD</h6></div><span>&nbsp;</span>
                    <div class=""col-xs-2 textBox2ch""><h6>MM</h6></div><span>&nbsp;</span>
                    <div class=""col-xs-2 textBox4ch""><h6>YYYY</h6></div>
                    <span>&nbsp;</span>
                    <span>&nbsp;</span>
                    <span>&nbsp;</span>
                    <div class=""col-xs-2 textBox2ch""><h6>hh</h6></div><span>&nbsp;</span>
                    <div class=""col-xs-2 textBox2ch""><h6>mm</h6></div>
                <");
            WriteLiteral(@"/div>
                <div class=""row"">
                    <div class=""col-xs-2"">
                        <input type=""number"" id=""DD"" maxlength=""2"" min=""1"" max=""31"" class=""form-control textBox2ch"">
                    </div>/
                    <div class=""col-xs-2"">
                        <input type=""number"" id=""MM"" maxlength=""2"" min=""1"" max=""12"" class=""form-control textBox2ch"">
                    </div>/
                    <div class=""col-xs-2"">
                        <input type=""number"" id=""YYYY"" maxlength=""4""");
            EndContext();
            BeginWriteAttribute("min", " min=\'", 3081, "\'", 3105, 1);
#line 62 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
WriteAttributeValue("", 3087, DateTime.Now.Year, 3087, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 3106, "\"", 3132, 2);
#line 62 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
WriteAttributeValue("", 3112, DateTime.Now.Year, 3112, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3130, "+1", 3130, 2, true);
            EndWriteAttribute();
            BeginContext(3133, 531, true);
            WriteLiteral(@" class=""form-control textBox4ch"">
                    </div>
                    
                    <span>&nbsp;</span>
                    <div class=""col-xs-2"">
                        <input type=""number"" id=""hh"" maxlength=""2"" min=""0"" max=""24"" class=""form-control textBox2ch"">
                    </div>:
                    <div class=""col-xs-2"">
                        <input type=""number"" id=""mm"" maxlength=""2"" min=""0"" max=""59"" class=""form-control textBox2ch"">
                    </div>
                </div>
");
            EndContext();
            BeginContext(3879, 36, true);
            WriteLiteral("            </div>\r\n        </div>\r\n");
            EndContext();
#line 80 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
        }
        else {

#line default
#line hidden
            BeginContext(3942, 103, true);
            WriteLiteral("           <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h6>Completed Date: ");
            EndContext();
            BeginContext(4046, 19, false);
#line 84 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                               Write(Model.CompletedDate);

#line default
#line hidden
            EndContext();
            BeginContext(4065, 44, true);
            WriteLiteral("</h6>\r\n            </div>\r\n        </div> \r\n");
            EndContext();
#line 87 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(4120, 69, true);
            WriteLiteral("\r\n        <p>&nbsp;</p>\r\n        <div class=\"row\">\r\n            <!-- ");
            EndContext();
#line 91 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                  if(Model.Progress<100){

#line default
#line hidden
            BeginContext(4215, 106, true);
            WriteLiteral("            <div class=\"col-md-3\">\r\n                \r\n                <button id=\"btnUpdateTask\" data-id=\"");
            EndContext();
            BeginContext(4322, 8, false);
#line 94 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                                               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4330, 93, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-success\">Save</button>\r\n                \r\n            </div>\r\n");
            EndContext();
#line 97 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(4436, 6, true);
            WriteLiteral(" -->\r\n");
            EndContext();
#line 98 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
             if(Model.CompletedDate==null){

#line default
#line hidden
            BeginContext(4487, 103, true);
            WriteLiteral("            <div class=\"col-md-5\">\r\n                \r\n                <button id=\"btnEndTask\" data-id=\"");
            EndContext();
            BeginContext(4591, 8, false);
#line 101 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4599, 97, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-success\">Complete</button>\r\n                \r\n            </div>\r\n");
            EndContext();
#line 104 "D:\Projects\ERP.Web\Views\WorkOrder\_TaskDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(4711, 339, true);
            WriteLiteral(@"            <div class=""col-md-3"">
                <button id=""btnCancelUpdateTask"" type=""button"" class=""btn btn-warning"">Close</button>
            </div>
        </div>
        <p>&nbsp;</p>
        <div class=""row"">
        <div id=""alertTaskErrorMessage"" class=""alert alert-danger hide""></div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkOrderTaskView> Html { get; private set; }
    }
}
#pragma warning restore 1591
