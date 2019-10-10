﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("sponsorType", Attributes = ForAttributeName)]
    public class SponsorTypeTagHelper : TagHelper
    {
        private readonly ISponsorTypesService sponsorTypeService;

        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public SponsorTypeTagHelper(ISponsorTypesService sponsorTypeService)
        {
            this.sponsorTypeService = sponsorTypeService;

        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSponsorTypes = sponsorTypeService.GetAllSponsorTypes();
            output.TagName = "select";

            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);


            output.Attributes.Add("class", "form-control");

            foreach (var sponsorType in allSponsorTypes)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };

                //acesta este atributul care este returnat de output-ul din TagHelper
                myOption.Attributes.Add("value", sponsorType.Id.ToString());
                //acesta este atributul care se afiseaza in elementul "option"
                myOption.InnerHtml.Append(sponsorType.Id.ToString());

                output.Content.AppendHtml(myOption);

            }
        }
    }
}
