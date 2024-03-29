#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\Manage_audit_zone_branches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b46d0b40a704649a0084368d43ca2b6a68c160d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setup_Manage_audit_zone_branches), @"mvc.1.0.view", @"/Views/Setup/Manage_audit_zone_branches.cshtml")]
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
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\_ViewImports.cshtml"
using IAMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\_ViewImports.cshtml"
using IAMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b46d0b40a704649a0084368d43ca2b6a68c160d", @"/Views/Setup/Manage_audit_zone_branches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Setup_Manage_audit_zone_branches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\Manage_audit_zone_branches.cshtml"
  
    ViewData["Title"] = "Manage Audit Zone Branches";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    var g_teams = [];
    var g_branches = [];
    $(document).ready(function () {
        $('#sidebar_policy').hide();
        $('.hiddenContainers').hide();
        $('.fieldAuditFields').hide();
        $('.nonFieldAuditFields').hide();
        $('#branchInfoArea').hide();

    });
    function getBusinessDateCount(startDate, endDate) {
        var elapsed, daysBeforeFirstSaturday, daysAfterLastSunday;
        var ifThen = function (a, b, c) {
            return a == b ? c : a;
        };

        elapsed = endDate - startDate;
        elapsed /= 86400000;

        daysBeforeFirstSunday = (7 - startDate.getDay()) % 7;
        daysAfterLastSunday = endDate.getDay();

        elapsed -= (daysBeforeFirstSunday + daysAfterLastSunday);
        elapsed = (elapsed / 7) * 5;
        elapsed += ifThen(daysBeforeFirstSunday - 1, -1, 0) + ifThen(daysAfterLastSunday, 6, 5);

        return Math.ceil(elapsed);
    }
    function ShowDepartmentAuditPeriods()");
            WriteLiteral(@" {
        if ($('#deptSelectionBox option:selected').val() == 0)
            $('.hiddenContainers').hide();
        else {
            $('.hiddenContainers').show();
            if ($('#deptSelectionBox option:selected').val() == '473') {
                $('.fieldAuditFields').show();
                $('.nonFieldAuditFields').hide();
            } else {
                $('.nonFieldAuditFields').show();
                $('.fieldAuditFields').hide();
            }
            $.ajax({
                url: ""/Planning/audit_periods"",
                type: ""POST"",
                data: {
                    'dept_code': $('#deptSelectionBox option:selected').val()
                },
                cache: false,
                success: function (data) {
                    $('#periodSelectionBox').empty();
                    $('#periodSelectionBox').append('<option value=""0"" id=""0"">--Select Audit Period--</option>')
                    console.log(data);
                    $.each(data, ");
            WriteLiteral(@"function (index, period) {
                        $('#periodSelectionBox').append('<option value=""' + period.id + '"" id=""' + period.id + '"">' + period.description + '</option>')
                    });

                },
                dataType: ""json"",
            });
            $.ajax({
                url: ""/Planning/audit_teams"",
                type: ""POST"",
                data: {
                    'dept_code': $('#deptSelectionBox option:selected').val()
                },
                cache: false,
                success: function (data) {
                    $('#teamSelectionBox').empty();
                    $('#teamSelectionBox').append('<option value=""0"" id=""0"">--Select Audit Team--</option>')
                    g_teams = data;
                    $.each(data, function (index, team) {
                        if (team.iS_TEAMLEAD == 'Y')
                            $('#teamSelectionBox').append('<option value=""' + team.code + '"" id=""' + team.code + '"">' + team.name + ");
            WriteLiteral(@"'</option>')
                    });

                },
                dataType: ""json"",
            });
        }
    }
    function ShowSelectedZonesBranches() {
        if ($('#auditZoneSelectionBox option:selected').val() == 0) {
            $('#branchSelectionBox').empty();
            $('#branchInfoArea').hide();
            $('#branchSelectionBox').append('<option value=""0"" id=""0"">--Select Audit Branch--</option>')
        }
        else {
            $('#branchSelectionBox').empty();
            $('#branchInfoArea').hide();
            $.ajax({
                url: ""/Planning/zone_branches"",
                type: ""POST"",
                data: {
                    'zone_code': $('#auditZoneSelectionBox option:selected').val()
                },
                cache: false,
                success: function (data) {
                    g_branches = data;
                    $('#branchSelectionBox').empty();
                    $('#branchInfoArea').hide();
                ");
            WriteLiteral(@"    $('#branchSelectionBox').append('<option value=""0"" id=""0"">--Select Audit Branch--</option>')
                    console.log(data);
                    $.each(data, function (index, branch) {
                        $('#branchSelectionBox').append('<option value=""' + branch.id + '"" id=""' + branch.id + '"">' + branch.description + '</option>')
                    });

                },
                dataType: ""json"",
            });
        }
    }
    function ShowSelectedDivisionDepartments() {
        if ($('#divSelectionBox option:selected').val() == 0) {
            $('#divDeptSelectionBox').empty();
            $('#divDeptSelectionBox').append('<option value=""0"" id=""0"">--Select Audit Department--</option>')
        }
        else {
            $('#divDeptSelectionBox').empty();
            $.ajax({
                url: ""/Planning/div_departments"",
                type: ""POST"",
                data: {
                    'div_code': $('#divSelectionBox option:selected').val()
");
            WriteLiteral(@"                },
                cache: false,
                success: function (data) {
                    $('#divDeptSelectionBox').empty();
                    $('#divDeptSelectionBox').append('<option value=""0"" id=""0"">--Select Audit Department--</option>')
                    console.log(data);
                    $.each(data, function (index, dept) {
                        $('#divDeptSelectionBox').append('<option value=""' + dept.id + '"" id=""' + dept.id + '"">' + dept.name + '</option>')
                    });

                },
                dataType: ""json"",
            });
        }
    }
    function ShowBranchInfoBox() {
        $('#branchInfoArea').show();
    }
    function previewAuditPlan() {
        $('#previewAuditPlan').modal('show');
        $('#auditorDept').text($('#deptSelectionBox option:selected').text());
        $('#auditorPlan').text($('#periodSelectionBox option:selected').text());
        $('#descModal_field').html($('#descriptionAuditPlanField').val()");
            WriteLiteral(@");
        if ($('#deptSelectionBox option:selected').val() == '473') {
            $('#divzone_field').text($('#auditZoneSelectionBox option:selected').text());
            $('#deptBranch_field').text($('#branchSelectionBox option:selected').text());

        } else {
            $('#divzone_field').text($('#divSelectionBox option:selected').text());
            $('#deptBranch_field').text($('#divDeptSelectionBox option:selected').text());

        }
        $('#exeFrom_field').html($('#executionPeriodFromField').val());
        $('#exeTo_field').html($('#executionPeriodToField').val());
        $('#operationalFrom_field').html($('#auditPeriodFromField').val());
        $('#operationalTo_field').html($('#auditPeriodToField').val());
        //
        if ($('#isTravelingRequiredField').is("":checked""))
            $('#travelingReq_field').html('Yes');
        else
            $('#travelingReq_field').html('No');
        $('#remarksAddtn_field').html($('#remarksAdditionalInfoField').val());");
            WriteLiteral(@"
        $('#teamName_field').text($('#teamSelectionBox option:selected').text());
        //
        var teamMembersFields = """";
        $.each(g_teams, function (index, team) {
            if (team.name == $('#teamSelectionBox option:selected').text()) {
                if (team.iS_TEAMLEAD == ""Y"")
                    teamMembersFields += team.employeename + "" "" + team.teammembeR_ID + "" (L)<br>"";
                else
                    teamMembersFields += team.employeename + "" "" + team.teammembeR_ID + "" (M)<br>"";
            }
        });
        $('#teamMembers_field').html(teamMembersFields);

    }
    function publishNewAuditPlanChanges(){
        var periodId = $('#periodSelectionBox option:selected').val();
        var stDate = $('#executionPeriodFromField').val();
        var edDate = $('#executionPeriodToField').val();
        var period_stDate = $('#auditPeriodFromField').val();
        var period_edDate = $('#auditPeriodToField').val();
        var conducted_by = $('#deptSele");
            WriteLiteral(@"ctionBox option:selected').val();
        var no_days = getBusinessDateCount(new Date(stDate), new Date(edDate));
        var zoneId = $('#auditZoneSelectionBox option:selected').val();
        var branchId = 0;
        if (zoneId != 0)
            branchId = $('#branchSelectionBox option:selected').val();

        var divId = $('#divSelectionBox option:selected').val();
        var deptId = 0;
        if (divId != 0)
            deptId = $('#divDeptSelectionBox option:selected').val();

        var teamId = $('#teamSelectionBox option:selected').val();
        var status = 1;
        var desc = $('#descriptionAuditPlanField').val() ;

       $.ajax({
           url: ""/Planning/add_audit_plan"",
            type: ""POST"",
            data: {
                'AUDITPERIOD_ID': periodId,
                'AUDIT_STARTDATE': stDate,
                'AUDIT_ENDDATE': edDate,
                'AUDITPERIOD_FROM': period_stDate,
                'AUDITPERIOD_TO': period_edDate,
                'AUDI");
            WriteLiteral(@"T_CONDUCTBY_DEPT': conducted_by,
                'NO_OF_DAYS_AUDIT': no_days,
                'AUDIT_ZONEID': zoneId,
                'BRANCHID': branchId,
                'DIVISION_ID': divId,
                'DEPARTMENT_ID': deptId,
                'TEAM_CONST_ID': teamId,
                'STATUS': status,
                'DESCRIPTION': desc
            },
            cache: false,
            success: function (data) {
                window.location.href = ""/Planning/audit_plan?dept="" + $('#deptSelectionBox option:selected').val() + ""&periodId="" + $('#periodSelectionBox option:selected').val();
            },
            dataType: ""json"",
        });
    }
</script>

<center>
<div class=""row col-md-12"">
    <h3 style=""color: #45c545;"">Manage Audit Zone Branches</h3>
</div>
<div class=""row mt-3 col-md-12"">
    <div class=""row col-md-4"">
        <h5>Audit Zone *</h5>
    </div>
    <div class=""row col-md-8"">
        <select id=""EntitySelectionBox"" class=""form-select form-control""");
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b46d0b40a704649a0084368d43ca2b6a68c160d14657", async() => {
                WriteLiteral("Select Audit Zone");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
    </div>
</div>

<div class=""row mt-3 col-md-12"">
    <div class=""row col-md-4"">
        <h5>Zone *</h5>
    </div>
    <div class=""row col-md-8"">
        <select id=""subentitySelectionBox"" class=""form-select form-control"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b46d0b40a704649a0084368d43ca2b6a68c160d16414", async() => {
                WriteLiteral("Select Zone");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
    </div>
</div>

<div class=""row col-md-12 mt-3"">
    <div class=""row col-md-4"">
        <h5>List of Branches</h5>
    </div>
    <div class=""row col-md-8"">
        <select id=""RiskCategorySelectionBox"" class=""form-select form-control"" aria-label=""Default select example"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b46d0b40a704649a0084368d43ca2b6a68c160d18216", async() => {
                WriteLiteral("List of Branches");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
    </div>
</div>
</center>

<div class=""row col-md-12 mt-3"">
    <div class=""row col-md-6 mt-3"">
    <button class=""btn-primary"" style=""float:right"">Save</button>
    </div>
    <div class=""row col-md-6 mt-3"">
        <button class=""btn-primary"" style=""float:left"">Clear Selection</button>
    </div>
</div>

<div class=""row w-100"">
    <table class=""table table-bordered mb-0 mt-3 bg-white table-hover table-striped"">
        <thead>
            <tr>
                <td width=""200""><h5>Audit Zone</h5></td>
                <td width=""200""><h5>Zone</h5></td>
                <td width=""200""><h5>Branches</h5></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
     ");
            WriteLiteral(@"           <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </tbody>
    </table>
</div>
<div class=""row col-md-12 mt-3"">
    <button class=""btn-primary"">Submit</button>
</div>

");
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
