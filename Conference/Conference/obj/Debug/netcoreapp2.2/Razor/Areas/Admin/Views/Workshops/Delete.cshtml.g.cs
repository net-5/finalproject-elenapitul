#pragma checksum "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f258c3194161512de148eead825bda1e186a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Workshops_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Workshops/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Workshops/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Workshops_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f258c3194161512de148eead825bda1e186a36", @"/Areas/Admin/Views/Workshops/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3136849290b850d351a485fa68b45d602e1adcf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Workshops_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.WorkshopsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 176, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>WorkshopViewModel</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(319, 38, false);
#line 16 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(357, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(416, 34, false);
#line 19 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(450, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(508, 40, false);
#line 22 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(548, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(607, 36, false);
#line 25 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(643, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(701, 47, false);
#line 28 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(748, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(807, 43, false);
#line 31 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(850, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(908, 49, false);
#line 34 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(957, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1016, 45, false);
#line 37 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1119, 48, false);
#line 40 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1226, 44, false);
#line 43 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1328, 51, false);
#line 46 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1438, 47, false);
#line 49 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1543, 43, false);
#line 52 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1645, 39, false);
#line 55 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1742, 45, false);
#line 58 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1846, 41, false);
#line 61 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1945, 52, false);
#line 64 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2056, 48, false);
#line 67 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\Workshops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(2134, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43f258c3194161512de148eead825bda1e186a3613795", async() => {
                BeginContext(2160, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />       \n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2249, 20, true);
            WriteLiteral("\n</div>\n\n<div>\r\n    ");
            EndContext();
            BeginContext(2269, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43f258c3194161512de148eead825bda1e186a3615553", async() => {
                BeginContext(2291, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2307, 9, true);
            WriteLiteral("\r\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.WorkshopsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
