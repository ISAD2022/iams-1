#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\branches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe1252f0507221db5c0088844af4fe5414364ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setup_branches), @"mvc.1.0.view", @"/Views/Setup/branches.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe1252f0507221db5c0088844af4fe5414364ff", @"/Views/Setup/branches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Setup_branches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Rawalpindi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Rawalpindi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Lahore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Lahore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Islamabad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Islamabad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Karachi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Karachi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\branches.cshtml"
  
    ViewData["Title"] = "Branch Setup";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#sidebar_policy').hide();
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfBranches tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newBranchSetup() {
        $('#setupBranchModal').modal('show');
        $('#branchCodeModalField').val('');
        $('#branchNameModalField').val('');
        $('#branchZoneModalField').val('');
        $('#branchAddressModalField').val('');
    }

    function setupBranch(code, name, zone, address, status) {
        $('#branchCodeModalField').val(code);
        $('#branchNameModalField').val(name);
        $('#branchZoneModalField').val(zone);
        $('#branchAddressModalField').val(address);
        if (status == ""Active"")
            $('#branchActiveModalField').click();
 ");
            WriteLiteral(@"       else if (status == ""Inactive"")
            $('#branchInactiveModalField').click();

        $('#setupBranchModal').modal('show');
    }

    function publishBranchChanges() {

        //$('#listOfBranches tbody').append('<tr><td></td>');
    }
</script>

<div class=""col-md-12"" style=""margin-top:20px;"">
    <h3>List of Branches</h3>
    <div class=""row"">
        <div class=""col-md-10"">
            <input class=""form-control"" id=""searchTableRecord"" type=""text"" placeholder=""Search.."">
        </div>
        <div class=""col-md-2"">
            <button onclick=""newBranchSetup();"" class=""btn btn-danger w-100"">Add New</button>
        </div>
    </div>
    <br>
    <table id=""listOfBranches"" class=""table align-middle mb-0 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th>Branch Code</th>
                <th>Branch Name</th>
                <th>Zone ID</th>
                <th>Address</th>
                <th>Status</th>
   ");
            WriteLiteral("             <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 67 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\branches.cshtml"
              
                if (ViewData["BranchList"] != null)
                {
                    foreach (var item in (dynamic)(ViewData["BranchList"]))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <td>
                                <p class=""fw-normal mb-1"">24402</p>
                            </td>
                            <td>
                                <p class=""fw-normal mb-1"">Head Office Branch</p>
                                <!--<p class=""text-muted mb-0"">IT department</p>-->
                            </td>
                            <td>
                                <p class=""fw-normal mb-1"">Islamabad</p>
                            </td>
                            <td>
                                <p class=""fw-normal mb-1"">1 Faisal Avenue G-7/1, Zero Point, Islamabad</p>
                            </td>
                            <td>
                                <span class=""badge badge-success rounded-pill d-inline"">Active</span>
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-link text-danger btn-sm bt");
            WriteLiteral(@"n-rounded"" onclick=""setupBranch('24402','Head Office Branch','Islamabad','1 Faisal Avenue G-7/1, Zero Point, Islamabad','Active');"">
                                    Edit
                                </button>
                            </td>
                        </tr>
");
#nullable restore
#line 96 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\branches.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- <tr>
                 <td>
                     <p class=""fw-normal mb-1"">24401</p>
                 </td>
                 <td>
                     <p class=""fw-normal mb-1"">Islamabad Branch</p>
                </td>
            <td>
                <p class=""fw-normal mb-1"">Islamabad</p>
            </td>
            <td>
                <p class=""fw-normal mb-1"">Zero Point, Islamabad</p>
            </td>

            <td>
                <span class=""badge badge-success rounded-pill d-inline"">Active</span>
            </td>
            <td>
                <button type=""button"" class=""btn btn-link text-danger btn-sm btn-rounded"" onclick=""setupBranch('24401','Islamabad Branch','Islamabad','Zero Point, Islamabad','Active');"">
                    Edit
                </button>
            </td>
            </tr>
            <tr>
                <td>
                    <p class=""fw-normal mb-1"">24403</p>
                </td>
                <td>
                ");
            WriteLiteral(@"    <p class=""fw-normal mb-1"">Rawalpind Cantt Branch</p>

                </td>
                <td>
                    <p class=""fw-normal mb-1"">Rawalpindi</p>
                </td>
                <td>
                    <p class=""fw-normal mb-1"">Old Airport1 Road, Rawalpindi</p>
                </td>


                <td>
                    <span class=""badge badge-success rounded-pill d-inline"">Active</span>
                </td>
                <td>
                    <button type=""button"" class=""btn btn-link text-danger btn-sm btn-rounded"" onclick=""setupBranch('24403','Rawalpind Cantt Branch','Rawalpindi','Old Airport1 Road, Rawalpindi','Active');"">
                        Edit
                    </button>
                </td>
            </tr>
            -->
        </tbody>
    </table>
</div>

<div id=""setupBranchModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div clas");
            WriteLiteral(@"s=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">Branch Setup</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe1252f0507221db5c0088844af4fe5414364ff12994", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""branchCodeModalField"">Branch Code</label>
                        <input type=""text"" class=""form-control"" id=""branchCodeModalField"" aria-describedby=""brcode"" placeholder=""Branch Code"">

                    </div>
                    <div class=""form-group"">
                        <label for=""branchNameModalField"">Branch Name</label>
                        <input type=""text"" class=""form-control"" id=""branchNameModalField"" placeholder=""Branch Name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""branchZoneModalField"">Zone</label>
                        <select id=""branchZoneModalField"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe1252f0507221db5c0088844af4fe5414364ff14083", async() => {
                    WriteLiteral("Rawalpindi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe1252f0507221db5c0088844af4fe5414364ff15304", async() => {
                    WriteLiteral("Lahore");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe1252f0507221db5c0088844af4fe5414364ff16521", async() => {
                    WriteLiteral("Islamabad");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe1252f0507221db5c0088844af4fe5414364ff17741", async() => {
                    WriteLiteral("Karachi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                    <div class=""form-group"">
                        <label for=""branchAddressModalField"">Address</label>
                        <textarea rows=""3"" class=""form-control"" id=""branchAddressModalField"" placeholder=""Branch Address"" draggable=""false""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label for=""branchAddressModalField"">Status</label>
                        <div class=""row col-md-12"">
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""branchActiveModalField"" value=""option1"" />
                                <label class=""form-check-label"" for=""branchActiveModalField"">Active</label>
                            </div>

                            <div class=""form-check form-check-inline"">
                                <inp");
                WriteLiteral(@"ut class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""branchInactiveModalField"" value=""option2"" />
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
