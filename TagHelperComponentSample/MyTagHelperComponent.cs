﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperComponentSample
{
    public class MyTagHelperComponent : ITagHelperComponent
    {
        private int _order;
        private string _html;

        public MyTagHelperComponent(int order, string html)
        {
            _order = order;
            _html = html;
        }

        public int Order => _order;

        public void Init(TagHelperContext context)
        {
        }

        public Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "footer", StringComparison.Ordinal) && output.Attributes.ContainsName("inject"))
            {
                output.PostContent.AppendHtml(_html);
            }

            return Task.FromResult(0);
        }
    }
}
