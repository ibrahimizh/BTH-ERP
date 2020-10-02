#pragma checksum "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Permissions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9736459fa7cd7e941a9e0b2a85dfc0f6bafe4aa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Permissions), @"mvc.1.0.view", @"/Views/Employee/Permissions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Permissions.cshtml", typeof(AspNetCore.Views_Employee_Permissions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9736459fa7cd7e941a9e0b2a85dfc0f6bafe4aa5", @"/Views/Employee/Permissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0fb84b3fa7568212f38bae63456c535fc95cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Permissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1382, true);
            WriteLiteral(@"
<div class=""card mb-3 shadow-lg rounded"">
    <div class=""card-header bg-info text-white"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h4 class=""card-title"">Employees - Permission Management</h4>
            </div>
        </div>
    </div>
    <div class=""card-body"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <p>Click on an employee to view/update his permissions</p>
                    <ul class=""list-group employeesList"">
                    </ul>
                </div>
                <div class=""col-lg-8"">
                    <h3 class=""headingPermissionsForEmployee""></h3>
                    <ul class=""list-group employeePermissionsList"">
                    </ul>
                    <p>&nbsp;</p>
                    <div class=""divUpdateEmployeePermissions"">

                    </div>
                    <p>&nbsp;</p>
                    <div class=""updateSu");
            WriteLiteral(@"ccess hide"">
                        <div class=""alert alert-success"">Permissions updated !</div>
                    </div>
                    <div class=""row updateError hide"">
                        <div class=""alert alert-danger""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1399, 224, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        getEmployees();\r\n\r\n        function getEmployees() {\r\n                $.ajax({\r\n                    type: \'GET\',\r\n                    url: \'");
                EndContext();
                BeginContext(1624, 37, false);
#line 47 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Permissions.cshtml"
                     Write(Url.Action("GetEmployees","Employee"));

#line default
#line hidden
                EndContext();
                BeginContext(1661, 949, true);
                WriteLiteral(@"'
                })
                    .done(function (data) {                        
                    $.each(data, function (index, value) {
                        console.log(JSON.stringify(value));
                        $("".employeesList"").append(""<li class='list-group-item'><a class='employeeLink' href='#' data-employeeid='""+value.id+""' data-employeename='""+value.firstName + "" "" + value.lastName+""'>"" + value.firstName + "" "" + value.lastName + ""</a></li>"");
                    });
                });
        }

        $("".employeesList"").on(""click"", "".employeeLink"", function () {
            $("".employeesList>li.active"").removeClass(""active"");
            $(this).parent(""li"").addClass(""active"");
            let selectedEmployeeId = $(this).data('employeeid');
            let selectedEmployeeName = $(this).data('employeename');
            $.ajax({
                    type: 'GET',
                    url: '");
                EndContext();
                BeginContext(2611, 39, false);
#line 64 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Permissions.cshtml"
                     Write(Url.Action("GetPermissions","Employee"));

#line default
#line hidden
                EndContext();
                BeginContext(2650, 1801, true);
                WriteLiteral(@"' + '/' + selectedEmployeeId
                })
                .done(function (data) {
                    $("".headingPermissionsForEmployee"").html('Permissions for '+selectedEmployeeName);
                    $("".employeePermissionsList"").html('');
                    $("".divUpdateEmployeePermissions"").html('');
                    $.each(data, function (index, value) {                        
                        console.log(JSON.stringify(value));
                        let checked = '';
                        if (value.hasAccess) checked = 'checked';
                        $("".employeePermissionsList"").append(""<li class='list-group-item'><div class='form-check'><label class='form-check-label'><input data-featureid=""+value.featureId+"" type='checkbox' class='form-check-input' value='' name='employeePermission' ""+checked+"">""+value.featureName+""</label></div></li>"");
                    });
                    $("".divUpdateEmployeePermissions"").append('<input type=""button"" class=""btn btn-pr");
                WriteLiteral(@"imary btnUpdatePermissions"" data-employeeId=""'+selectedEmployeeId+'"" value=""Update"" />');
                });
        });

        $("".divUpdateEmployeePermissions"").on(""click"", "".btnUpdatePermissions"", function () {
            let selectedEmployeeId = $(this).data('employeeid');
            var updatePermissionsModel = {
                ""employeeId"": selectedEmployeeId,
                ""featureIds"":[]                      
            };
            $.each($(""input[name='employeePermission']:checked""), function () {
                updatePermissionsModel.featureIds.push($(this).data('featureid'));
            });
            console.log(JSON.stringify(updatePermissionsModel));
            $.ajax({
                type: 'POST',
                url: '");
                EndContext();
                BeginContext(4452, 31, false);
#line 92 "D:\Projects\BTH-ERP-Latest\ERP.Web\Views\Employee\Permissions.cshtml"
                 Write(Url.Action("UpdatePermissions"));

#line default
#line hidden
                EndContext();
                BeginContext(4483, 560, true);
                WriteLiteral(@"',
                data: JSON.stringify(updatePermissionsModel),
                contentType: ""application/json;""
            })
                .done(function (data) {
                    // show the response
                    if (data === ""Success"") {
                        $("".updateSuccess"").fadeIn().delay(2000).fadeOut();
                    }
                    else {
                        $("".updateError"").html(data).fadeIn().delay(2000).fadeOut();
                    }

                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
