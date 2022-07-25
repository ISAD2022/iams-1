#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c1568156de089a0364fcc3b4b633b23cb0aa7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministrationPanel_groups), @"mvc.1.0.view", @"/Views/AdministrationPanel/groups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c1568156de089a0364fcc3b4b633b23cb0aa7b", @"/Views/AdministrationPanel/groups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministrationPanel_groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
  
    ViewData["Title"] = "Groups";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">
    $(document).ready(function () {
        var g_groupId = 0;
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfGroups tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newGroupSetup() {
        g_groupId = 0;
        $('#setupGroupModal').modal('show');
        $('#groupNameModalField').val('');
        $('#groupDescModalField').val('');
        $('#branchZoneModalField').val('');
        $('#branchSizeModalField').val('');
        $('#branchRiskModalField').val('');
    }

    function setupGroup(name, description, active, grpId) {
        g_groupId = grpId;
        $('#groupNameModalField').val(code);
        $('#groupDescModalField').val(name);
        $('#branchZoneModalField').val(zoneId);
        $('#branchSizeModalField').val(sizeId);
        $('");
            WriteLiteral(@"#branchRiskModalField').val(risk);
        if (status == ""Active"")
            $('#groupActiveModalField').click();
        else if (status == ""InActive"")
            $('#groupInactiveModalField').click();

        $('#setupGroupModal').modal('show');
    }

    function publishGroupChanges() {

        var code = $('#groupNameModalField').val();
        var name = $('#groupDescModalField').val();
        var zoneId = $('#branchZoneModalField').val();
        var zone_name = $('#branchZoneModalField option:selected').text();
        var sizeId = $('#branchSizeModalField').val();
        var size = $('#branchSizeModalField option:selected').text();
        var risk = $('#branchRiskModalField').val();
        var status;
        var badge;
        if ($('#groupActiveModalField').is(':checked')) {
            status = 'Active';
            badge = 'badge-success ';
        }
        else {
            status = 'InActive';
            badge = 'badge-danger ';
        }
        if (g_gr");
            WriteLiteral(@"oupId == 0)
            var row = ""<tr id=\""div_"" + g_groupId + "" \""><td><p class=\""fw - normal mb - 1\"">"" + code + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + name + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + zone_name + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + size + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + risk + ""</p></td><td><span class=\""badge "" + badge + "" rounded - pill d - inline\"">"" + status + ""</span></td><td><button type=\""button\"" class=\""btn btn - link text - danger btn - sm btn - rounded\"" onclick=\""setupGroup('"" + code + ""', '"" + name + ""', '"" + zone_name + ""', '"" + zoneId + ""', '"" + size + ""', '"" + sizeId + ""', '"" + risk + ""', '"" + status + ""', '"" + g_groupId + ""'); \"" > Edit</button></td ></tr >"";
        else
            $('#div_' + g_groupId).html(""<td><p class=\""fw - normal mb - 1\"">"" + code + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + name + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + zone_name + ""</p></td><td><p class=\""fw - normal mb - 1\""");
            WriteLiteral(@">"" + size + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + risk + ""</p></td><td><span class=\""badge "" + badge + "" rounded - pill d - inline\"">"" + status + ""</span></td><td><button type=\""button\"" class=\""btn btn - link text - danger btn - sm btn - rounded\"" onclick=\""setupGroup('"" + code + ""', '"" + name + ""', '"" + zone_name + ""', '"" + zoneId + ""', '"" + size + ""', '"" + sizeId + ""', '"" + risk + ""', '"" + status + ""', '"" + g_groupId + ""'); \"" > Edit</button></td >"");
        $('#listOfGroups tbody').append(row);
        $('#setupGroupModal').modal('hide');
        $.ajax({
            url: ""/Setup/branch_add"",
            type: ""POST"",
            data: {
                'BRANCHID': g_groupId,
                'BRANCHCODE': code,
                'BRANCHNAME': name,
                'ZONEID': zoneId,
                'BRANCH_SIZE_ID': sizeId,
                'BRANCH_SIZE': size,
                'ZONE_NAME': zone_name,
                'ISACTIVE': status
            },
            cache: false,
    ");
            WriteLiteral(@"        success: function (data) {
                console.log(data);
                window.location = window.location.pathname;

            },
            dataType: ""json"",
        });
    }
</script>

<div class=""col-md-12"" style=""margin-top:20px;"">
    <h3>List of Groups</h3>
    <div class=""row"">
        <div class=""col-md-10"">
            <input class=""form-control"" id=""searchTableRecord"" type=""text"" placeholder=""Search.."">
        </div>
        <div class=""col-md-2"">
            <button onclick=""newGroupSetup();"" class=""btn btn-danger w-100"">Add New</button>
        </div>
    </div>
    <br>
    <table id=""listOfGroups"" class=""table align-middle mb-0 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th>Group Name</th>
                <th>Group Description</th>
                <th>Status</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 114 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
              
                if (ViewData["GroupsList"] != null)
                {
                    foreach (var item in (dynamic)(ViewData["GroupsList"]))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 5363, "\"", 5386, 2);
            WriteAttributeValue("", 5368, "div_", 5368, 4, true);
#nullable restore
#line 120 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
WriteAttributeValue("", 5372, item.GROUP_ID, 5372, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 122 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
                                                     Write(item.GROUP_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 125 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
                                                     Write(item.GROUP_DESCRIPTION);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"dept_status\">\r\n");
#nullable restore
#line 128 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
                                  
                                    if (item.ISACTIVE == "Y")

                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-success rounded-pill d-inline\">Active</span>");
#nullable restore
#line 131 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
                                                                                                           }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-danger rounded-pill d-inline\">InActive</span>");
#nullable restore
#line 133 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
                                                                                                        }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-link text-danger btn-sm btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6314, "\"", 6415, 9);
            WriteAttributeValue("", 6324, "setupGroup(\'", 6324, 12, true);
#nullable restore
#line 137 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
WriteAttributeValue("", 6336, item.GROUP_NAME, 6336, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6352, "\',\'", 6352, 3, true);
#nullable restore
#line 137 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
WriteAttributeValue("", 6355, item.GROUP_DESCRIPTION, 6355, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6378, "\',\'", 6378, 3, true);
#nullable restore
#line 137 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
WriteAttributeValue("", 6381, item.ISACTIVE, 6381, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6395, "\',\'", 6395, 3, true);
#nullable restore
#line 137 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
WriteAttributeValue("", 6398, item.GROUP_ID, 6398, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6412, "\');", 6412, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Edit\r\n                                </button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 142 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\AdministrationPanel\groups.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div id=""setupGroupModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">Group Setup</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c1568156de089a0364fcc3b4b633b23cb0aa7b14269", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""groupNameModalField"">Group Name</label>
                        <input type=""text"" class=""form-control"" id=""groupNameModalField"" aria-describedby=""brcode"" placeholder=""Group Name"">

                    </div>
                    <div class=""form-group"">
                        <label for=""groupDescModalField"">Group Description</label>
                        <textarea rows=""3""  class=""form-control"" id=""groupDescModalField"" placeholder=""Group Description""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label for=""groupStatusModalField"">Status</label>
                        <div class=""row col-md-12"">
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""groupActiveModalField"" value=""option1"" />
                                <label");
                WriteLiteral(@" class=""form-check-label"" for=""groupActiveModalField"">Active</label>
                            </div>

                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""groupInactiveModalField"" value=""option2"" />
                                <label class=""form-check-label"" for=""groupInactiveModalField"">Inactive</label>
                            </div>
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
                <button onclick=""publishGroupChanges();"" type=""button"" class=""btn btn-danger"">Save changes</button>
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
