#pragma checksum "C:\Cmder\Conference\Conference\Conference\Views\Workshops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa1098497a14cf5b5fecf8d4e53147bef91bbae8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workshops_Index), @"mvc.1.0.view", @"/Views/Workshops/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Workshops/Index.cshtml", typeof(AspNetCore.Views_Workshops_Index))]
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
#line 1 "C:\Cmder\Conference\Conference\Conference\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Cmder\Conference\Conference\Conference\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa1098497a14cf5b5fecf8d4e53147bef91bbae8", @"/Views/Workshops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730217b378615efac836ac18994c698ac7ffdc81", @"/Views/_ViewImports.cshtml")]
    public class Views_Workshops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Workshops>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Cmder\Conference\Conference\Conference\Views\Workshops\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(915, 2633, true);
            WriteLiteral(@"
<div class="""">

    <section class=""container"">
        <div>
            <h1 class=""title mv container"">Workshops</h1>
        </div>
        <div class=""parent row"">
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-time"">22/02, 14:00 - 18:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/2019/Workshops/Details/1"">
                        Deep-Dive in Asp Core
                    </a>
                </div>


                <span class=""sub-title mv"">Irina Scurtu</span>
                <a target=""_blank"" href=""NULLhttps://www.eventbrite.com/e/workshop-deep-dive-in-asp-core-22-tickets-55864731917"" class=""btn btn-primary"">Register</a>
            </div>
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-time"">22/02, 14:00 - 18:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/2019/Workshops/Details/2"">
               ");
            WriteLiteral(@"         dotnet with Docker on Linux
                    </a>
                </div>


                <span class=""sub-title mv"">Andrei Mustata</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/dotnet-with-docker-on-linux-tickets-55864650674"" class=""btn btn-primary"">Register</a>
            </div>
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-time"">22/02, 9:00 - 13:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/2019/Workshops/Details/3"">
                        Clean Code: Dive beyond the theory
                    </a>
                </div>


                <span class=""sub-title mv"">Mihaela Ghidersa</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/clean-code-dive-beyond-the-theory-tickets-55864850271"" class=""btn btn-primary"">Register</a>
            </div>
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-");
            WriteLiteral(@"time"">22/02, 9:00 - 13:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/2019/Workshops/Details/4"">
                        Applied serverless: event-driven processing in Azure
                    </a>
                </div>


                <span class=""sub-title mv"">Andrei Scutariu</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/workshop-azure-serverless-event-processing-tickets-55864704836"" class=""btn btn-primary"">Register</a>
            </div>
        </div>

    </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Workshops>> Html { get; private set; }
    }
}
#pragma warning restore 1591