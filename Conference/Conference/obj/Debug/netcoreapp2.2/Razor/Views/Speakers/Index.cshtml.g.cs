#pragma checksum "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba25b33089afd702d18a463a97cf128e46d3460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Speakers_Index), @"mvc.1.0.view", @"/Views/Speakers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Speakers/Index.cshtml", typeof(AspNetCore.Views_Speakers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba25b33089afd702d18a463a97cf128e46d3460", @"/Views/Speakers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be8d0068d1dbf6cb25cef3d7c9155a0bc4de030", @"/Views/_ViewImports.cshtml")]
    public class Views_Speakers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Speakers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 77, true);
            WriteLiteral("\n<div class=\"\">\n    <div class=\"container\">\n        <div class=\"row parent\">\n");
            EndContext();
#line 11 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
            BeginContext(274, 184, true);
            WriteLiteral("                <div class=\"col-sm-12 col-lg-3 child\" style=\"background-image: url(~/img/angry.jpg)\">\n\n                    <div class=\"details\">\n                        <a class=\"link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 458, "\"", 537, 4);
            WriteAttributeValue("", 465, "/", 465, 1, true);
#line 17 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 466, item.Edition, 466, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 479, "/speakers/", 479, 10, true);
#line 17 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 489, string.Format(item.FirstName+"-"+item.LastName), 489, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 49, true);
            WriteLiteral(">\n                            <span class=\"name\">");
            EndContext();
            BeginContext(588, 13, false);
#line 18 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                                          Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(601, 59, true);
            WriteLiteral("</span>\n                            <span class=\"position\">");
            EndContext();
            BeginContext(661, 13, false);
#line 19 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                                              Write(item.Position);

#line default
#line hidden
            EndContext();
            BeginContext(674, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(677, 16, false);
#line 19 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                                                              Write(item.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(693, 92, true);
            WriteLiteral("</span>\n\n                        </a>\n                        <ul class=\"speaker-socials\">\n\n");
            EndContext();
#line 24 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                             if (item.Twitter != null)

                            {

#line default
#line hidden
            BeginContext(871, 113, true);
            WriteLiteral("                                <li>\n                                    <a target=\"_blank\" class=\"link d-inline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 984, "\"", 1004, 1);
#line 28 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 991, item.Twitter, 991, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1005, 152, true);
            WriteLiteral(">\n                                        <i class=\"fab fa-twitter\"></i>\n                                    </a>\n                                </li>\n");
            EndContext();
#line 32 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(1188, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 36 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                             if (item.Website != null)
                            {

#line default
#line hidden
            BeginContext(1275, 114, true);
            WriteLiteral("                                <li>\n\n                                    <a target=\"_blank\" class=\"link d-inline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1389, "\"", 1409, 1);
#line 40 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 1396, item.Website, 1396, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1410, 148, true);
            WriteLiteral(">\n                                        <i class=\"fa fa-link\"></i>\n                                    </a>\n                                </li>\n");
            EndContext();
#line 44 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1588, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 46 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                             if (item.LinkedIn != null)
                            {


#line default
#line hidden
            BeginContext(1676, 113, true);
            WriteLiteral("                                <li>\n                                    <a target=\"_blank\" class=\"link d-inline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1810, 1);
#line 50 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 1796, item.LinkedIn, 1796, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1811, 153, true);
            WriteLiteral(">\n                                        <i class=\"fab fa-linkedin\"></i>\n                                    </a>\n                                </li>\n");
            EndContext();
#line 54 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1994, 85, true);
            WriteLiteral("\n                        </ul>\n\n\n                    </div>\n\n\n                </div>\n");
            EndContext();
#line 63 "C:\Users\APE\Desktop\finalproject-elenapitul-feature-1\finalproject-elenapitul-feature-1\Conference\Conference\Views\Speakers\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2093, 36, true);
            WriteLiteral("\n\n        </div>\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Speakers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
