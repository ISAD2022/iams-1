#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68cdb42d0d02140965bf8f284c32e2a81b7f2b46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planning_team_members), @"mvc.1.0.view", @"/Views/Planning/team_members.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68cdb42d0d02140965bf8f284c32e2a81b7f2b46", @"/Views/Planning/team_members.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Planning_team_members : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml"
  
    ViewData["Title"] = "Team Members";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">
    .editRole {
        display: inline-block;
        cursor: pointer;
    }

    .selectRole {
        display: none;
    }
</style>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#sidebar_policy').hide();
        $('#listofEmployeesContainer').hide();
        
        $(""#searchTeamFormation"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfEmployeeTeam tbody tr"").filter(function () {

                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
        
    });
   
    function ShowEmployeeContainer() {
        console.log($('#deptSelectionBox option:selected').val());
        if ($('#deptSelectionBox option:selected').val() == 0)
            $('#listofEmployeesContainer').hide();
        else {
            $('#listofEmployeesContainer').show();
          
            $.ajax({
                url: ""/Planning/audit_team");
            WriteLiteral(@""",
                type: ""POST"",
                data: {
                    'dept_code': $('#deptSelectionBox option:selected').val()
                },
                cache: false,
                success: function (data) {
                    $('#listOfEmployeeTeam tbody').empty();
                    console.log(data);
                    var teamId = 0;
                    var srNo = 1;
                    var teamMembers=[];
                    $.each(data, function (index, team) {
                        var teamLeadStr = '(M)';
                        if (team.iS_TEAMLEAD == ""Y"")
                            teamLeadStr = '(L)'
                        if (team.id != teamId) {
                            $('#listOfEmployeeTeam tbody').append('<tr id=teamcode_' + team.id + '><td class=""searchable""><p class=""fw-normal mb-1"">' + srNo + '</p></td><td class=""searchable""><p class=""fw-normal mb-1"">' + team.name + ' </p></td><td class=""searchable""><p class=""empName fw-normal mb-1"">' + team.emp");
            WriteLiteral(@"loyeename + ' ' + teamLeadStr + ' </p></td><td><small class=""text-danger deleteTeam"">Delete</small></td></tr>')
                            teamId = team.id;
                            srNo++;
                        } else {
                            teamMembers.push(team);
                        }
                    });
                    $.each(teamMembers, function (index, team) {
                        if (team.iS_TEAMLEAD != ""Y"")
                          {
                            prevText = $('#listOfEmployeeTeam tbody #teamcode_' + team.id + ' .empName').text();
                            $('#listOfEmployeeTeam tbody #teamcode_' + team.id + ' .empName').text(prevText + ', ' + team.employeename + "" (M)"");
                        }
                    });
                },
                dataType: ""json"",
            });
        }
    }
    function addNewTeam() {
        $('#setupAuditTeam').modal('show');
    }
</script>
<div class=""row mt-3"">
    <h5>Select Depar");
            WriteLiteral("tment</h5>\r\n    <select id=\"deptSelectionBox\" onchange=\"ShowEmployeeContainer();\" class=\"form-select form-control\" aria-label=\"Default select example\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68cdb42d0d02140965bf8f284c32e2a81b7f2b467219", async() => {
                WriteLiteral("Select Your Department");
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
            WriteLiteral("\r\n");
#nullable restore
#line 82 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml"
          
            if (ViewData["AuditDepartments"] != null)
            {
                foreach (var item in (dynamic)(ViewData["AuditDepartments"]))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68cdb42d0d02140965bf8f284c32e2a81b7f2b469088", async() => {
#nullable restore
#line 87 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml"
                                                          Write(item.NAME);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml"
                       WriteLiteral(item.CODE);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 87 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml"
AddHtmlAttributeValue("", 3597, item.CODE, 3597, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 88 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\team_members.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </select>
</div>
<div id=""listofEmployeesContainer"" class=""row mt-3 hide"">
    <div class=""row mt-2 w-100"">
        <div class=""col-md-6"">
            <h5>Team Formation</h5>
        </div>
        <div class=""col-md-6"">
            <button onclick=""addNewTeam();"" class=""btn-danger"" style=""float:right;"">Add New</button>
        </div>
    </div>
    <table id=""listOfEmployeeTeam"" class=""table align-middle mb-0 mt-2 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th class=""col-md-1"">Sr No.</th>
                <th class=""col-md-3"">Team Name</th>
                <th class=""col-md-7"">Team Members</th>
                <th class=""col-md-1""></th>
            </tr>
        </thead>
        <tbody>
            <tr><td class=""searchable""><p class=""fw-normal mb-1"">1</p></td><td class=""searchable""><p class=""fw-normal mb-1"">Team A</p></td><td class=""searchable""><p class=""fw-normal mb-1"">Ali Asif (L), Muhammad Aqib (M)</p></td><td><small cl");
            WriteLiteral(@"ass=""text-danger deleteTeam"">Delete</small></td></tr>

        </tbody>
    </table>

</div>

<div id=""setupAuditTeam"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">New Audit Team</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68cdb42d0d02140965bf8f284c32e2a81b7f2b4613315", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""branchCodeModalField"">Team Name</label>
                        <input type=""text"" class=""form-control"" id=""teamNameModalField"" aria-describedby=""brcode"" placeholder=""Team Name"">

                    </div>
                    <div class=""form-group"">

                        <label class=""col-md-3"">Participant</label>
                        <label for=""branchNameModalField"">Auditors</label>
                        <label for=""branchNameModalField"">Auditors</label>
                        <div class=""row"" style=""padding-left:20px;"">
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-6""><label>Ali Asif</label></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-6""><label>Muh");
                WriteLiteral(@"ammad Aqib</label></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-6""><label>Asfand Yar Javaid</label></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                            <div class=""col-md-6""><label>Arshad Javed</label></div>
                            <div class=""col-md-3""><input type=""checkbox"" /></div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button onclick=""publishNewTeamChanges();"" type=""button"" class=""btn btn-danger"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
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
