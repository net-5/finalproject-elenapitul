#pragma checksum "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "570ca31beaf9ab556ac062bb650ef635373dfc9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SponsorTypes_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SponsorTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SponsorTypes/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SponsorTypes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570ca31beaf9ab556ac062bb650ef635373dfc9c", @"/Areas/Admin/Views/SponsorTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4421ca34645b3b391b737f4bed54e87484dc45d5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SponsorTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.SponsorTypes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 25, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(170, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "570ca31beaf9ab556ac062bb650ef635373dfc9c4869", async() => {
                BeginContext(193, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(207, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(294, 38, false);
#line 17 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(332, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(385, 40, false);
#line 20 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(425, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(478, 41, false);
#line 23 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(519, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(572, 43, false);
#line 26 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(615, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 32 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(742, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(801, 37, false);
#line 36 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(838, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(903, 39, false);
#line 39 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(942, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1007, 40, false);
#line 42 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Order));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1112, 42, false);
#line 45 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1219, 53, false);
#line 48 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1296, 59, false);
#line 49 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1379, 57, false);
#line 50 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 53 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Areas\Admin\Views\SponsorTypes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1487, 34, true);
            WriteLiteral("    </tbody>\n</table>\n\n<div>\r\n    ");
            EndContext();
            BeginContext(1521, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "570ca31beaf9ab556ac062bb650ef635373dfc9c12505", async() => {
                BeginContext(1565, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1581, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.SponsorTypes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
