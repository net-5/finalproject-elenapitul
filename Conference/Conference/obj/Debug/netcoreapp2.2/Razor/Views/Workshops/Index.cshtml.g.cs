#pragma checksum "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Workshops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67313a6e537f3db389eb885374c033f9eadab805"
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
#line 1 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67313a6e537f3db389eb885374c033f9eadab805", @"/Views/Workshops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be8d0068d1dbf6cb25cef3d7c9155a0bc4de030", @"/Views/_ViewImports.cshtml")]
    public class Views_Workshops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Workshops>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Workshops\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 2781, true);
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
                    <a class=""name"" href=""/Workshops/Details/1"">
                        Deep-Dive in Asp Core
                    </a>
                </div>


                <span class=""sub-title mv"">Irina Scurtu</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/workshop-deep-dive-in-asp-core-22-tickets-55864731917"" class=""btn btn-primary"">Register</a>
            </div>
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-time"">22/02, 14:00 - 18:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/Workshops/Details/2"">
                        dotne");
            WriteLiteral(@"t with Docker on Linux
                    </a>
                </div>


                <span class=""sub-title mv"">Andrei Mustata</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/dotnet-with-docker-on-linux-tickets-55864650674"" class=""btn btn-primary"">Register</a>
            </div>
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-time"">22/02, 9:00 - 13:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/Workshops/Details/3"">
                        Clean Code: Dive beyond the theory
                    </a>
                </div>


                <span class=""sub-title mv"">Mihaela Ghidersa</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/clean-code-dive-beyond-the-theory-tickets-55864850271"" class=""btn btn-primary"">Register</a>
            </div>
            <div class=""col-lg-3 child workshop"">
                <span class=""talk-time"">22/02, 9:00 -");
            WriteLiteral(@" 13:00</span>
                <div class=""text-big mv fixed"">
                    <a class=""name"" href=""/Workshops/Details/4"">
                        Applied serverless: event-driven processing in Azure
                    </a>
                </div>


                <span class=""sub-title mv"">Andrei Scutariu</span>
                <a target=""_blank"" href=""https://www.eventbrite.com/e/workshop-azure-serverless-event-processing-tickets-55864704836"" class=""btn btn-primary"">Register</a>
            </div>
        </div>

    </section>

</div>

<div class="""">
        <section class=""container"">
            <div>
                <h1>Workshops</h1>
            </div>
            <div class=""parent row"">
");
            EndContext();
#line 75 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Workshops\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2994, 197, true);
            WriteLiteral("                    <div class=\"col-lg-3 child workshop\">\r\n                        <div class=\"text-big mv fixed\">\r\n                            <a class=\"name\" href=\"aici o sa pui adresa generata\">");
            EndContext();
            BeginContext(3192, 39, false);
#line 79 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Workshops\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3231, 91, true);
            WriteLiteral("</a>\r\n                        </div>\r\n\r\n                        <span class=\"sub-title mv\">");
            EndContext();
            BeginContext(3323, 44, false);
#line 82 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Workshops\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(3367, 154, true);
            WriteLiteral("</span>\r\n                        <a target=\"_blank\" href=\"https://www.eventbrite.com\" class=\"btn btn-primary\">Register</a>\r\n\r\n                    </div>\r\n");
            EndContext();
#line 86 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Workshops\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3540, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n\r\n    </div>");
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
