#pragma checksum "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d7fe42fa6fc2fcbb1e7c9b26299f9a801cd2b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Speakers_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Speakers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Speakers/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Speakers_Details))]
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
#line 1 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d7fe42fa6fc2fcbb1e7c9b26299f9a801cd2b4", @"/Areas/Admin/Views/Speakers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3136849290b850d351a485fa68b45d602e1adcf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Speakers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Domain.Entities.Speakers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h3>Speakers</h3>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(266, 44, false);
#line 15 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(310, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(372, 40, false);
#line 18 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(412, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(473, 38, false);
#line 21 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(511, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(573, 34, false);
#line 24 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(607, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(668, 45, false);
#line 27 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(713, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(775, 41, false);
#line 30 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(816, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(877, 44, false);
#line 33 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(921, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(983, 40, false);
#line 36 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1084, 44, false);
#line 39 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1190, 40, false);
#line 42 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1291, 43, false);
#line 45 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1396, 39, false);
#line 48 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1496, 44, false);
#line 51 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1602, 40, false);
#line 54 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1703, 41, false);
#line 57 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1806, 37, false);
#line 60 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1904, 44, false);
#line 63 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2010, 40, false);
#line 66 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2111, 41, false);
#line 69 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2214, 37, false);
#line 72 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2251, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2312, 42, false);
#line 75 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2416, 38, false);
#line 78 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2515, 43, false);
#line 81 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2620, 39, false);
#line 84 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2720, 47, false);
#line 87 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2767, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2829, 43, false);
#line 90 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2933, 50, false);
#line 93 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(2983, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3045, 46, false);
#line 96 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(3091, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3152, 47, false);
#line 99 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3199, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3261, 43, false);
#line 102 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3304, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3365, 44, false);
#line 105 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3471, 40, false);
#line 108 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3511, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3572, 43, false);
#line 111 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3615, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3677, 39, false);
#line 114 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3716, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3764, 54, false);
#line 119 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3818, 27, true);
            WriteLiteral("    \r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3845, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3d7fe42fa6fc2fcbb1e7c9b26299f9a801cd2b421647", async() => {
                BeginContext(3867, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3883, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Domain.Entities.Speakers> Html { get; private set; }
    }
}
#pragma warning restore 1591
