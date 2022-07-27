#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0d5b58b944cb972d982a0ee2d46236be6e6ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setup_control_voilation), @"mvc.1.0.view", @"/Views/Setup/control_voilation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0d5b58b944cb972d982a0ee2d46236be6e6ab8", @"/Views/Setup/control_voilation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Setup_control_voilation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
  

    ViewData["Title"] = "Branch Setup";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">
    $(document).ready(function () {
        var g_branchId = 0;
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfBranches tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newBranchSetup() {
        g_branchId = 0;
        $('#setupBranchModal').modal('show');
        $('#branchCodeModalField').val('');
        $('#branchNameModalField').val('');
        $('#branchZoneModalField').val('');
        $('#branchSizeModalField').val('');
        $('#branchRiskModalField').val('');
    }

    function setupBranch(code, name, zone, zoneId, size, sizeId,risk, status,brId ) {
        g_branchId = brId;
        $('#branchCodeModalField').val(code);
        $('#branchNameModalField').val(name);
        $('#branchZoneModalField').val(zoneId);
        $('#branchSizeMo");
            WriteLiteral(@"dalField').val(sizeId);
        $('#branchRiskModalField').val(risk);
        if (status == ""Active"")
            $('#branchActiveModalField').click();
        else if (status == ""InActive"")
            $('#branchInactiveModalField').click();

        $('#setupBranchModal').modal('show');
    }

    function publishBranchChanges() {

        var code = $('#branchCodeModalField').val();
        var name = $('#branchNameModalField').val();
        var zoneId = $('#branchZoneModalField').val();
        var zone_name = $('#branchZoneModalField option:selected').text();
        var sizeId = $('#branchSizeModalField').val();
        var size = $('#branchSizeModalField option:selected').text();
        var risk = $('#branchRiskModalField').val();
        var status;
        var badge;
        if ($('#branchActiveModalField').is(':checked')) {
            status = 'Active';
            badge = 'badge-success ';
        }
        else {
            status = 'InActive';
            badge = 'b");
            WriteLiteral(@"adge-danger ';
        }
        if (g_branchId == 0)
            var row = ""<tr id=\""div_"" + g_branchId + "" \""><td><p class=\""fw - normal mb - 1\"">"" + code + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + name + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + zone_name + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + size + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + risk + ""</p></td><td><span class=\""badge "" + badge + "" rounded - pill d - inline\"">"" + status + ""</span></td><td><button type=\""button\"" class=\""btn btn - link text - danger btn - sm btn - rounded\"" onclick=\""setupBranch('"" + code + ""', '"" + name + ""', '"" + zone_name + ""', '"" + zoneId + ""', '"" + size + ""', '"" + sizeId + ""', '"" + risk + ""', '"" + status + ""', '"" + g_branchId + ""'); \"" > Edit</button></td ></tr >"";
        else
            $('#div_' + g_branchId).html(""<td><p class=\""fw - normal mb - 1\"">"" + code + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + name + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + zone_name");
            WriteLiteral(@" + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + size + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + risk + ""</p></td><td><span class=\""badge "" + badge + "" rounded - pill d - inline\"">"" + status + ""</span></td><td><button type=\""button\"" class=\""btn btn - link text - danger btn - sm btn - rounded\"" onclick=\""setupBranch('"" + code + ""', '"" + name + ""', '"" + zone_name + ""', '"" + zoneId + ""', '"" + size + ""', '"" + sizeId + ""', '"" + risk + ""', '"" + status + ""', '"" + g_branchId + ""'); \"" > Edit</button></td >"");
        $('#listOfBranches tbody').append(row);
        $('#setupBranchModal').modal('hide');
        $.ajax({
            url: ""/Setup/branch_add"",
            type: ""POST"",
            data: {
                'BRANCHID': g_branchId,
                'BRANCHCODE': code,
                'BRANCHNAME': name,
                'ZONEID': zoneId,
                'BRANCH_SIZE_ID': sizeId,
                'BRANCH_SIZE': size,
                'ZONE_NAME': zone_name,
                'ISACTIVE': s");
            WriteLiteral(@"tatus
            },
            cache: false,
            success: function (data) {
                console.log(data);
                window.location = window.location.pathname;

            },
            dataType: ""json"",
        });
    }
</script>

<div class=""row col-md-12"" style=""margin-top:20px;"">
        <div class=""col-md-10"">
            <h3>Control Violations</h3>   
        </div>
        <div class=""col-md-2"">
            <button onclick=""newBranchSetup();"" style=""float:right;""class=""btn btn-danger w-100"">Add New</button>
        </div>
    
    <br>
    <div class=""col-md-12"">
         <table id=""controlviolation"" class=""table align-middle mb-0 bg-white table-hover table-striped"">
                <thead class=""bg-light"">
                    <tr>
                        <th>Name</th>
                        <th>Maximum Number</th>
                        <th>Status</th>
                        <th>Actions</th>
                    </tr>
                </thead>
 ");
            WriteLiteral("               <tbody>\r\n");
#nullable restore
#line 113 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                      
                        if (ViewData["BranchList"] != null)
                        {
                            foreach (var item in (dynamic)(ViewData["BranchList"]))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("id", " id=\"", 5484, "\"", 5507, 2);
            WriteAttributeValue("", 5489, "div_", 5489, 4, true);
#nullable restore
#line 119 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 5493, item.BRANCHID, 5493, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                    <td>\r\n                                        <p class=\"fw-normal mb-1\">");
#nullable restore
#line 122 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                                             Write(item.ZONE_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td>\r\n                                        <p class=\"fw-normal mb-1\">");
#nullable restore
#line 125 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                                             Write(item.BRANCH_SIZE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n\r\n                                    <td class=\"dept_status\">\r\n");
#nullable restore
#line 129 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                          
                                            if (item.ISACTIVE == "Active")

                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-success rounded-pill d-inline\">");
#nullable restore
#line 132 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                                                                                 Write(item.ISACTIVE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 132 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                                                                                                           }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-danger rounded-pill d-inline\">");
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                                                                            Write(item.ISACTIVE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                                                                                                                      }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-link text-danger btn-sm btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6579, "\"", 6753, 17);
            WriteAttributeValue("", 6589, "setupBranch(\'", 6589, 13, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6602, item.BRANCHCODE, 6602, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6618, "\',\'", 6618, 3, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6621, item.BRANCHNAME, 6621, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6637, "\',\'", 6637, 3, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6640, item.ZONE_NAME, 6640, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6655, "\',\'", 6655, 3, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6658, item.ZONEID, 6658, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6670, "\',\'", 6670, 3, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6673, item.BRANCH_SIZE, 6673, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6690, "\',\'", 6690, 3, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6693, item.BRANCH_SIZE_ID, 6693, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6713, "\',\'\',\'", 6713, 6, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6719, item.ISACTIVE, 6719, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6733, "\',\'", 6733, 3, true);
#nullable restore
#line 138 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
WriteAttributeValue("", 6736, item.BRANCHID, 6736, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6750, "\');", 6750, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Edit\r\n                                        </button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 143 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\control_voilation.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
       
    </div>
</div>

<div id=""setupBranchModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">Control Violation</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0d5b58b944cb972d982a0ee2d46236be6e6ab816384", async() => {
                WriteLiteral(@"
           
                    <div class=""form-group"">
                        <label for=""branchAddressModalField"">Status</label>
                        <div class=""row col-md-12"">
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""branchActiveModalField"" value=""option1"" />
                                <label class=""form-check-label"" for=""branchActiveModalField"">Active</label>
                            </div>

                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""branchInactiveModalField"" value=""option2"" />
                                <label class=""form-check-label"" for=""branchInactiveModalField"">Inactive</label>
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
                <button onclick=""publishBranchChanges();"" type=""button"" class=""btn btn-danger"">Save changes</button>
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