#pragma checksum "C:\Cmder\Conference\Conference\Conference\Areas\Admin\Views\List\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f002dd487d13e4aeada956efc40df0d91e2a3e35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_List_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/List/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/List/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_List_Index))]
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
#line 1 "C:\Cmder\Conference\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Cmder\Conference\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f002dd487d13e4aeada956efc40df0d91e2a3e35", @"/Areas/Admin/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730217b378615efac836ac18994c698ac7ffdc81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Cmder\Conference\Conference\Conference\Areas\Admin\Views\List\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 3830, true);
            WriteLiteral(@"
<h1>Table of Contents</h1>

<div class=""container"">
    
    <div class=""row align-items-start"">
        <div class=""col"">
            <ul>
                <li> <a href=""http://localhost:26590/Admin/Editions""> List of Editions </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Editions/Create""> Create Edition </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Editions/Edit""> Update Edition </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Editions/Details/1""> Edition Details </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Editions/Delete""> Delete Edition </a> </li>
            </ul>

        </div>
        <div class=""col"">
            <ul>
                <li> <a href=""http://localhost:26590/Admin/Speakers""> List of Speakers </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Speakers/Create""> Create Speaker </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Speakers/Edit""");
            WriteLiteral(@"> Update Speaker </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Speakers/Details/1""> Speaker Details </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Speakers/Delete""> Delete Speaker </a> </li>
            </ul>
        </div>
        <div class=""col"">
            <ul>
                <li> <a href=""http://localhost:26590/Admin/Sponsors""> List of Sponsors </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Sponsors/Create""> Create Sponsors </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Sponsors/Edit""> Update Sponsor </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Sponsors/Details/1""> Sponsor Details </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Sponsors/Delete""> Delete Sponsor </a> </li>
            </ul>
        </div>

    </div>


</div>

<div class=""container"">
    <div class=""row align-items-end"">
        <div class=""col"">
            <ul>
             ");
            WriteLiteral(@"   <li> <a href=""http://localhost:26590/Admin/SponsorTypes""> List of Sponsor Types </a> </li>
                <li> <a href=""http://localhost:26590/Admin/SponsorTypes/Create""> Create Sponsors Type </a> </li>
                <li> <a href=""http://localhost:26590/Admin/SponsorTypes/Edit""> Update Sponsor Types</a> </li>
                <li> <a href=""http://localhost:26590/Admin/SponsorTypes/Details/1""> Sponsor Type Details </a> </li>
                <li> <a href=""http://localhost:26590/Admin/SponsorTypes/Delete""> Delete Sponsor Type </a> </li>
            </ul>
        </div>
        <div class=""col"">
            <ul>
                <li> <a href=""http://localhost:26590/Admin/Talks""> List of Talks </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Talks/Create""> Create Talk </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Talks/Edit""> Update Talk</a> </li>
                <li> <a href=""http://localhost:26590/Admin/Talks/Details/1""> Talk Details </a> </li>
      ");
            WriteLiteral(@"          <li> <a href=""http://localhost:26590/Admin/Talks/Delete""> Delete Talks </a> </li>
            </ul>

        </div>
        <div class=""col"">
            <ul>
                <li> <a href=""http://localhost:26590/Admin/Workshops""> List of Workshops </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Workshops/Create""> Create Workshops </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Workshops/Edit""> Update Workshops</a> </li>
                <li> <a href=""http://localhost:26590/Admin/Workshops/Details/1""> Workshops Details </a> </li>
                <li> <a href=""http://localhost:26590/Admin/Workshops/Delete""> Delete Workshops </a> </li>
            </ul>
        </div>
    </div>
</div>");
            EndContext();
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
