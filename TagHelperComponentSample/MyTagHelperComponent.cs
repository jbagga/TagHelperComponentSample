using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperComponentSample
{
    public class MyTagHelperComponent : TagHelperComponent
    {
        public override int Order => 1;

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml($"<script>console.log('The time on the server is {DateTime.Now}')</script> \r\n");
            }
            if (string.Equals(context.TagName, "footer", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml($"<script>document.write('The time on the server is {DateTime.Now}.')</script> \r\n");
            }
            return Task.CompletedTask;
        }
    }
}
