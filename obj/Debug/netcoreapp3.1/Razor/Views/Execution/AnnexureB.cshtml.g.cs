#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Execution\AnnexureB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3dbc6088fd7f58eb20567f47b258de79388316a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Execution_AnnexureB), @"mvc.1.0.view", @"/Views/Execution/AnnexureB.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dbc6088fd7f58eb20567f47b258de79388316a", @"/Views/Execution/AnnexureB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Execution_AnnexureB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Execution\AnnexureB.cshtml"
  
    ViewData["Title"] = "Annexure - B";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $('#document').ready(function () {
        $('#sidebar_policy').hide();
    });
</script>
<div class=""row"" style=""margin-top:50px;"">
    <div class=""row w-100"">
        <h2 style=""display:block;"">BRANCH INSPECTION REPORT FORMAT</h2>
    </div>
    <div class=""row w-100"">
        <h5 style=""display:block;"">1. Basic Information</h5>
    </div>
    <table class=""table table-bordered"" id=""1. Basic Information table align-middle mb-0 mt-3 bg-white table-hover table-striped"">
        <tbody>
            <tr>
                <td>Branch</td>
                <td><input type=""text"" /></td>
                <td>Zone</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>Br. Address</td>
                <td><input type=""text"" /></td>
                <td>Last Inspection Conducted on</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>Distance from I&C Fi");
            WriteLiteral(@"eld Unit</td>
                <td><input type=""text"" /></td>
                <td>Last Audit</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>Date of this Inspection</td>
                <td><input type=""text"" /></td>
                <td>Last visit by ZM Ops on</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>Name of Team Head Conducting this Inspection</td>
                <td><input type=""text"" /></td>
                <td>Designation</td>
                <td><input type=""text"" /></td>
            </tr>
        </tbody>

    </table>
</div>
<div class=""row"" style=""margin-top:50px;"">
    <div class=""row w-100"">
        <h6 style=""display:block;"">Data to be captured at profiling stage from HRIS (PP.No.</h6><input type=""text"" />  <h6> ) / Branch Code</h6><input type=""text"" />

    </div>
</div>
<div>
    <table class=""table table-bordered"" id=""a) Basic Info about Branch ");
            WriteLiteral(@"Manager table mb-0 mt-3 bg-white table-hover table-striped"">
        <thead>
            <tr>
                <td style=""text-align:left;"" colspan=""4"">a) Basic Info about Branch Manager</td>
            </tr>
        </thead>
        <tbody>
            <br />
            <tr>
                <td> Name of Branch Manager</td>
                <td><input type=""text"" /></td>
                <td>Designation</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>P.P. Number</td>
                <td><input type=""text"" /></td>
                <td>Age</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>Posted in this branch since</td>
                <td><input type=""text"" /></td>
                <td>Reasons for posting period exceeding 3 years. (if applicable)</td>
                <td><input type=""text"" /></td>
            </tr>
            <tr>
                <td>Years of service wit");
            WriteLiteral(@"h ZTBL</td>
                <td><input type=""text"" /></td>
                <td>Years remaining to retirement</td>
                <td><input type=""text"" /></td>
            </tr>

        </tbody>
    </table>
    <div class=""col-md-6 mt-5"">
        <button onclick=""window.location.href = './AnnexureB_2';"" class=""btn-primary"" style=""float:right;"">Next</button>
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
