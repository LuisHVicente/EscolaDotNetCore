using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FanSoft.Escola.MVCUI.Infra.TagHelpers
{
    public class BreadCrumbTagHelper : TagHelper
    {
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var pageController = ViewContext.RouteData.Values["controller"];
            var pageAction = ViewContext.RouteData.Values["action"];
            output.TagName = "nav";

            output.Content.SetHtmlContent(
                $@"<ol class='breadcrumb'>
                    <li class='breadcrumb-item'><a href='#'>Home</a></li>
                    <li class='breadcrumb-item active'><a href='#'>Library</a></li>
                </ol>"
            );
            output.TagMode = TagMode.StartTagAndEndTag;

        }
    }
}
