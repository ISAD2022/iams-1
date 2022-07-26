#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d154d69a8a6db4c7116b1fdbb6428606e230692b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setup_process_review), @"mvc.1.0.view", @"/Views/Setup/process_review.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d154d69a8a6db4c7116b1fdbb6428606e230692b", @"/Views/Setup/process_review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Setup_process_review : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
  
    ViewData["Title"] = "Review Processes";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">

    .listItems:hover {
        color: blue;
        text-decoration: underline;
    }

    .action:hover {
        font-size: 110%;
        cursor: pointer;
        font-weight: 600;
    }
</style>

<script type=""text/javascript"">
    $(document).ready(function () {
        var g_groupId = 0;
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfProcTransactions tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newGroupSetup() {
        g_groupId = 0;
        $('#recommendReferProcTransactionModal').modal('show');
        $('#groupNameModalField').val('');
        $('#groupDescModalField').val('');
    }

    function recommendReferProcTransaction(id) {
       
        $('#recommendReferProcTransactionModal').modal('show');
        $.ajax({
            url: ""/S");
            WriteLiteral(@"etup/process_transactions"",
            type: ""POST"",
            data: {
                'transactionId': id
            },
            cache: false,
            success: function (data) {
                var tr = data[0];
                $('#viewerMainProcNameModalField').val(tr.procesS_NAME);
                $('#viewerNameModalField').val(tr.suB_PROCESS_NAME);
                $('#viewerDescModalField').val(tr.description);
                $('#viewerControlModalField').val(tr.controL_OWNER);
                $('#viewerDivModalField').val(tr.diV_NAME);
                $('#viewerActionModalField').val(tr.action);
                $('#viewerRiskModalField').val(tr.risK_WEIGHTAGE);
                $('#viewerRiskMaxModalField').val(tr.risK_MAX_NUMBER);
            },
            dataType: ""json"",
        });
    }

    function recommendProcTransaction() {

        var name = $('#groupNameModalField').val();
        var desc = $('#groupDescModalField').val();
        var status;
        v");
            WriteLiteral(@"ar badge;
        if ($('#groupActiveModalField').is(':checked')) {
            status = 'Y';
            badge = 'badge-success ';
        }
        else {
            status = 'N';
            badge = 'badge-danger ';
        }
        $.ajax({
            url: ""/AdministrationPanel/group_add"",
            type: ""POST"",
            data: {
                'GROUP_ID': g_groupId,
                'GROUP_NAME': name,
                'GROUP_DESCRIPTION': desc,
                'ISACTIVE': status
            },
            cache: false,
            success: function (data) {
                $('#recommendReferProcTransactionModal').modal('hide');
                console.log(data);
                window.location = window.location.pathname;

            },
            dataType: ""json"",
        });
    }
</script>

<div class=""col-md-12"" style=""margin-top:20px;"">
    <h3>List of Process Transactions to Review </h3>
    <div class=""row"">
        <div class=""col-md-12"">
            <in");
            WriteLiteral(@"put class=""form-control"" id=""searchTableRecord"" type=""text"" placeholder=""Search.."">
        </div>
    </div>
    <br>
    <table id=""listOfProcTransactions"" class=""table align-middle mb-0 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th>Process Name</th>
                <th>Sub Process Name</th>
                <th>Description</th>
                <th>Function Responsible</th>
                <th>Control Violation</th>
                <th>Risk Weightage</th>
                <th>Status</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 119 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
              
            if (ViewData["TransactionsList"] != null)
            {
            foreach (var item in (dynamic)(ViewData["TransactionsList"]))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 4009, "\"", 4026, 2);
            WriteAttributeValue("", 4014, "div_", 4014, 4, true);
#nullable restore
#line 125 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
WriteAttributeValue("", 4018, item.ID, 4018, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 127 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                     Write(item.PROCESS_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 130 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                     Write(item.SUB_PROCESS_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 133 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                     Write(item.DESCRIPTION);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 136 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                     Write(item.DIV_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\"></p>\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 142 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                  
                                    if (item.RISK_WEIGHTAGE == 3)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"fw-normal mb-1\">High</p>");
#nullable restore
#line 144 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                                       }
                                    else if (item.RISK_WEIGHTAGE == 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"fw-normal mb-1\">Medium</p>");
#nullable restore
#line 146 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                                         }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"fw-normal mb-1\">Low</p>");
#nullable restore
#line 148 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                                      }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 152 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
                                                     Write(item.PROCESS_STATUS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"action btn btn-link text-danger btn-sm btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5609, "\"", 5661, 3);
            WriteAttributeValue("", 5619, "recommendReferProcTransaction(\'", 5619, 31, true);
#nullable restore
#line 155 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
WriteAttributeValue("", 5650, item.ID, 5650, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5658, "\');", 5658, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Details\r\n                                </button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 160 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\process_review.cshtml"
            }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div id=""recommendReferProcTransactionModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">Transaction Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d154d69a8a6db4c7116b1fdbb6428606e230692b13435", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""viewerMainProcNameModalField"">Process Name</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerMainProcNameModalField"" aria-describedby=""Process Name"" placeholder=""Process Name"">

                    </div>
                    <div class=""form-group"">
                        <label for=""viewerNameModalField"">Sub Process Name</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerNameModalField"" aria-describedby=""Process Name"" placeholder=""Process Name"">

                    </div>
                    <div class=""form-group"">
                        <label for=""viewerDescModalField"">Description</label>
                        <textarea class=""form-control"" disabled id=""viewerDescModalField"" aria-describedby=""Enter Description here..."" placeholder=""Enter Description here...""></textarea>

                    </div>
                    <div cl");
                WriteLiteral(@"ass=""form-group"">
                        <label for=""viewerControlModalField"">Control Owner</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerControlModalField"" aria-describedby=""Control Owner"" placeholder=""Control Owner"">
                    </div>
                    <div class=""form-group"">
                        <label for=""viewerDivModalField"">Division</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerDivModalField"" aria-describedby=""Control Owner"" placeholder=""Control Owner"">
                    </div>
                    <div class=""form-group"">
                        <label for=""viewerActionModalField"">Action</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerActionModalField"" aria-describedby=""Action"" placeholder=""Action"">
                    </div>
                    <div class=""form-group"">
                        <label for=""viewerRiskModalField"">Risk Weightage");
                WriteLiteral(@"</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerRiskModalField"" aria-describedby=""Action"" placeholder=""Action"">
                    </div>
                    <div class=""form-group"">
                        <label for=""viewerRiskMaxModalField"">Risk Max Number</label>
                        <input type=""text"" disabled class=""form-control"" id=""viewerRiskMaxModalField"" aria-describedby=""Control Owner"">
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
                <button onclick=""refferedBackProcTransaction();"" type=""button"" class=""btn btn-secondary"">Refer Back</button>
                <button onclick=""recommendProcTransaction();"" type=""button"" class=""btn btn-danger"">Recommend</button>

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
