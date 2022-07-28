#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e796d8c61356751c409860875cb6d9e06c3c87e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setup_sub_entities), @"mvc.1.0.view", @"/Views/Setup/sub_entities.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e796d8c61356751c409860875cb6d9e06c3c87e3", @"/Views/Setup/sub_entities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Setup_sub_entities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
  

    ViewData["Title"] = "Sub Entities";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">
    $(document).ready(function () {
        var g_entityId = 0;
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listofSubEntities tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newSubEntitySetup() {
        g_entityId = 0;
        $('#setupSubEntityModal').modal('show');
        $('#divCodeModalField').val('0');
        $('#entityNameModalField').val('');
        $('#deptCodeModalField').val('0');
    }

    function setupSubEntity(divCode, deptCode,entName, status, entId) {
        g_entityId = entId;
        $('#divCodeModalField').val(divCode);
        $('#entityNameModalField').val(entName);
        $('#deptCodeModalField').val(deptCode);
        if (status == ""Active"")
            $('#activeModalField').click();
        else if (status == ""InActive"")
");
            WriteLiteral(@"            $('#inActiveModalField').click();

        $('#setupSubEntityModal').modal('show');
    }

    function publishSubEntityChanges() {

        var divCode = $('#divCodeModalField option:selected').val();
        var divName = $('#divCodeModalField option:selected').text();
        var entityName = $('#entityNameModalField').val();
        var deptCode = $('#deptCodeModalField option:selected').val();
        var deptName = $('#deptCodeModalField option:selected').text();
        
        var status;
        var badge;
        if ($('#activeModalField').is(':checked')) {
            status = 'Active';
            badge = 'badge-success ';
        }
        else {
            status = 'InActive';
            badge = 'badge-danger ';
        }
        if (g_entityId == 0)
            var row = ""<tr id=\""div_"" + g_entityId + "" \""><td><p class=\""fw - normal mb - 1\"">"" + divName + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + deptName + ""</p></td><td><p class=\""fw - normal mb -");
            WriteLiteral(@" 1\"">"" + entityName + ""</p></td><td><span class=\""badge "" + badge + "" rounded - pill d - inline\"">"" + status + ""</span></td><td><button type=\""button\"" class=\""btn btn - link text - danger btn - sm btn - rounded\"" onclick=\""setupSubEntity('"" + divCode + ""', '"" + deptCode + ""', '"" + entityName + ""', '"" + status + ""', '"" + g_entityId + ""'); \"" > Edit</button></td ></tr >"";
        else
            $('#div_' + g_entityId).html(""<td><p class=\""fw - normal mb - 1\"">"" + divName + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + deptName + ""</p></td><td><p class=\""fw - normal mb - 1\"">"" + entityName + ""</p></td><td><span class=\""badge "" + badge + "" rounded - pill d - inline\"">"" + status + ""</span></td><td><button type=\""button\"" class=\""btn btn - link text - danger btn - sm btn - rounded\"" onclick=\""setupSubEntity('"" + divCode + ""', '"" + deptCode + ""', '"" + entityName + ""', '"" + status + ""','"" + g_entityId + ""'); \"" > Edit</button></td >"");
        $('#listofSubEntities tbody').append(row);
        $('#setupSub");
            WriteLiteral(@"EntityModal').modal('hide');
        $.ajax({
            url: ""/Setup/add_sub_entity"",
            type: ""POST"",
            data: {
                'ID': g_entityId,
                'NAME': entityName,
                'DIV_ID': divCode,
                'DEP_ID': deptCode,
                'STATUS': status
                
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

<div class=""col-md-12"" style=""margin-top:20px;"">
    <h3>List of Sub Entities</h3>
    <div class=""row"">
        <div class=""col-md-10"">
            <input class=""form-control"" id=""searchTableRecord"" type=""text"" placeholder=""Search.."">
        </div>
        <div class=""col-md-2"">
            <button onclick=""newSubEntitySetup();"" class=""btn btn-danger w-100"">Add New</button>
        </div>
    </div>
    <br>
   ");
            WriteLiteral(@" <table id=""listofSubEntities"" class=""table align-middle mb-0 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th>Division Name</th>
                <th>Branch Name</th>
                <th>Sub Entity Name</th>
                <th>Status</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 107 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
              
                if (ViewData["SubEntitiesList"] != null)
                {
                    foreach (var item in (dynamic)(ViewData["SubEntitiesList"]))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 4791, "\"", 4808, 2);
            WriteAttributeValue("", 4796, "div_", 4796, 4, true);
#nullable restore
#line 113 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
WriteAttributeValue("", 4800, item.ID, 4800, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 115 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                     Write(item.Division_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 118 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                     Write(item.Department_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td>\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 121 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                     Write(item.NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                           \r\n                            <td class=\"dept_status\">\r\n");
#nullable restore
#line 125 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                  
                                    if (item.STATUS == "Active")

                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-success rounded-pill d-inline\">");
#nullable restore
#line 128 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                                                         Write(item.STATUS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 128 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                                                                                 }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-danger rounded-pill d-inline\">");
#nullable restore
#line 130 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                                                    Write(item.STATUS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 130 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                                                                                            }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-link text-danger btn-sm btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5922, "\"", 6017, 11);
            WriteAttributeValue("", 5932, "setupSubEntity(\'", 5932, 16, true);
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
WriteAttributeValue("", 5948, item.DIV_ID, 5948, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5960, "\',\'", 5960, 3, true);
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
WriteAttributeValue("", 5963, item.DEP_ID, 5963, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5975, "\',\'", 5975, 3, true);
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
WriteAttributeValue("", 5978, item.NAME, 5978, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5988, "\',\'", 5988, 3, true);
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
WriteAttributeValue("", 5991, item.STATUS, 5991, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6003, "\',\'", 6003, 3, true);
#nullable restore
#line 134 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
WriteAttributeValue("", 6006, item.ID, 6006, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6014, "\');", 6014, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Edit\r\n                                </button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 139 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div id=""setupSubEntityModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">Add Sub Entity</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e796d8c61356751c409860875cb6d9e06c3c87e315894", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"divCodeModalField\">Division</label>\r\n                        <select id=\"divCodeModalField\"  class=\"form-select form-control\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e796d8c61356751c409860875cb6d9e06c3c87e316405", async() => {
                    WriteLiteral("--Select Division--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 160 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                              
                                if (ViewData["DivisionList"] != null)
                                {
                                    foreach (var item in (dynamic)(ViewData["DivisionList"]))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e796d8c61356751c409860875cb6d9e06c3c87e318313", async() => {
#nullable restore
#line 165 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
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
#line 165 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                           WriteLiteral(item.DIVISIONID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 165 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
AddHtmlAttributeValue("", 7464, item.DIVISIONID, 7464, 16, false);

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
#line 166 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </select>

                    </div>
                   
                    <div class=""form-group"">
                        <label for=""deptCodeModalField"">Department</label>
                        <select id=""deptCodeModalField"" class=""form-select form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e796d8c61356751c409860875cb6d9e06c3c87e321311", async() => {
                    WriteLiteral("--Select Department--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 178 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                              
                                if (ViewData["DepartmentList"] != null)
                                {
                                    foreach (var item in (dynamic)(ViewData["DepartmentList"]))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e796d8c61356751c409860875cb6d9e06c3c87e323225", async() => {
#nullable restore
#line 183 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
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
#line 183 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 183 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
AddHtmlAttributeValue("", 8359, item.ID, 8359, 8, false);

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
#line 184 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Setup\sub_entities.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""entityNameModalField"">Name</label>
                        <input id=""entityNameModalField"" class=""form-control form-text""  />
                        
                    </div>
                    <div class=""form-group"">
                        <label for=""isActiveModalField"">Status</label>
                        <div class=""row col-md-12"">
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""activeModalField"" value=""option1"" />
                                <label class=""form-check-label"" for=""activeModalField"">Active</label>
                            </div>

                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadi");
                WriteLiteral(@"oOptions"" id=""inActiveModalField"" value=""option2"" />
                                <label class=""form-check-label"" for=""inActiveModalField"">Inactive</label>
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
                <button onclick=""publishSubEntityChanges();"" type=""button"" class=""btn btn-danger"">Save changes</button>
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
