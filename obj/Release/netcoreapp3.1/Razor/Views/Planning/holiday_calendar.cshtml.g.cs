#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\holiday_calendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68db737b7d01a87828964c3edef05f90f98b02a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planning_holiday_calendar), @"mvc.1.0.view", @"/Views/Planning/holiday_calendar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68db737b7d01a87828964c3edef05f90f98b02a", @"/Views/Planning/holiday_calendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Planning_holiday_calendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\holiday_calendar.cshtml"
  
    ViewData["Title"] = "Holiday Calendar";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#sidebar_policy').hide();
    })
</script>
<div class=""row text-center"" style=""margin-top:50px;"">
    <H2 style="" display:block;color: #45c545;"">HOLIDAY CALENDAR</H2>

</div>
<ul>
    <li>Kashmir Day ""05 February""</li>
    <li>Pakistan Day ""23 March""</li>
    <li>Labor Day ""01 May""</li>
    <li>Independence Day ""14 August""</li>
    <li>Quaid-e-Azam Day / Christmas ""25 December""</li>

</ul>
<br />
<div class=""input-group"">
    <span class=""input-group-addon"" id=""basic-addon1"" style=""margin-right: 72px;"">Eid-ul-Fitr</span >

    <br />
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1"" style=""margin-right:10px;""> 
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1"">
</div>

<br />

<div class=""input-group"">
    <span class=""input-group-addon"" id=""basic-addon1"" style=""margin-right: 58px;"">Eid-ul-Azha </span>
 ");
            WriteLiteral(@"   <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1""style=""margin-right:10px;"">
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1"">
</div>
<br />
<div class=""input-group"">
    <span class=""input-group-addon"" id=""basic-addon1"" style=""margin-right: 10px;"">Eid Milad-un-Nabi </span>
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1""style=""margin-right:10px;"">
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1"">
</div>
<br />
<div class=""input-group"">
    <span class=""input-group-addon"" id=""basic-addon1"" style=""margin-right: 90px;"">Ashura </span>
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1""style=""margin-right:10px;"">
    <input type=""date"" class=""form-control"" placeholder=""Username"" aria-describedby=""basic-addon1"">
</div>
<br />

<br />

<div class=""btn-grou");
            WriteLiteral("p\" role=\"group\" aria-label=\"...\">\r\n    <button type=\"button\" class=\"btn btn-default\">Submit</button>\r\n</div>\r\n");
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
