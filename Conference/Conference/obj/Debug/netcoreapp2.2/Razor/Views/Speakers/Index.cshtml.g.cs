#pragma checksum "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47397f5dc07db46027628f7b34fd0a12bd3ec1c9"
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
#line 1 "C:\Cmder\Conference\Conference\Conference\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Cmder\Conference\Conference\Conference\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47397f5dc07db46027628f7b34fd0a12bd3ec1c9", @"/Views/Speakers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730217b378615efac836ac18994c698ac7ffdc81", @"/Views/_ViewImports.cshtml")]
    public class Views_Speakers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Speakers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 81, true);
            WriteLiteral("\r\n<div class=\"\">\r\n    <div class=\"container\">\r\n        <div class=\"row parent\">\r\n");
            EndContext();
#line 11 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
            BeginContext(287, 186, true);
            WriteLiteral("                <div class=\"col-sm-12 col-lg-3 child\" style=\"background-image:url(~/img/angry.jpg)\">\r\n\r\n                    <div class=\"details\">\r\n                        <a class=\"link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 473, "\"", 552, 4);
            WriteAttributeValue("", 480, "/", 480, 1, true);
#line 17 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 481, item.Edition, 481, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 494, "/speakers/", 494, 10, true);
#line 17 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 504, string.Format(item.FirstName+"-"+item.LastName), 504, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(553, 50, true);
            WriteLiteral(">\r\n                            <span class=\"name\">");
            EndContext();
            BeginContext(604, 13, false);
#line 18 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                                          Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(617, 60, true);
            WriteLiteral("</span>\r\n                            <span class=\"position\">");
            EndContext();
            BeginContext(678, 13, false);
#line 19 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                                              Write(item.Position);

#line default
#line hidden
            EndContext();
            BeginContext(691, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(694, 16, false);
#line 19 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                                                              Write(item.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(710, 97, true);
            WriteLiteral("</span>\r\n\r\n                        </a>\r\n                        <ul class=\"speaker-socials\">\r\n\r\n");
            EndContext();
#line 24 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                             if (item.Twitter != null)

                            {

#line default
#line hidden
            BeginContext(896, 114, true);
            WriteLiteral("                                <li>\r\n                                    <a target=\"_blank\" class=\"link d-inline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1030, 1);
#line 28 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 1017, item.Twitter, 1017, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1031, 156, true);
            WriteLiteral(">\r\n                                        <i class=\"fab fa-twitter\"></i>\r\n                                    </a>\r\n                                </li>\r\n");
            EndContext();
#line 32 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(1220, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 36 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                             if (item.Website != null)
                            {

#line default
#line hidden
            BeginContext(1311, 116, true);
            WriteLiteral("                                <li>\r\n\r\n                                    <a target=\"_blank\" class=\"link d-inline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1447, 1);
#line 40 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 1434, item.Website, 1434, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1448, 152, true);
            WriteLiteral(">\r\n                                        <i class=\"fa fa-link\"></i>\r\n                                    </a>\r\n                                </li>\r\n");
            EndContext();
#line 44 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1631, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                             if (item.LinkedIn != null)
                            {


#line default
#line hidden
            BeginContext(1723, 114, true);
            WriteLiteral("                                <li>\r\n                                    <a target=\"_blank\" class=\"link d-inline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1837, "\"", 1858, 1);
#line 50 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
WriteAttributeValue("", 1844, item.LinkedIn, 1844, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1859, 157, true);
            WriteLiteral(">\r\n                                        <i class=\"fab fa-linkedin\"></i>\r\n                                    </a>\r\n                                </li>\r\n");
            EndContext();
#line 54 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2047, 93, true);
            WriteLiteral("\r\n                        </ul>\r\n\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n");
            EndContext();
#line 63 "C:\Cmder\Conference\Conference\Conference\Views\Speakers\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2155, 42, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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