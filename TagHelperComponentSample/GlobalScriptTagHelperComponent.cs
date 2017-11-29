using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperComponentSample
{
    public class GlobalScriptTagHelperComponent : ITagHelperComponent
    {
        private int _order = 0;

        private string _style;

        public GlobalScriptTagHelperComponent()
        {
            _style = File.ReadAllText("scriptTag.html");
        }

        public int Order => _order;

        public void Init(TagHelperContext context)
        {
        }

        public Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "head", StringComparison.Ordinal) && !output.Attributes.ContainsName("inject"))
            {
                output.PostContent.AppendHtml(_style);
            }

            return Task.FromResult(0);
        }
    }
}
