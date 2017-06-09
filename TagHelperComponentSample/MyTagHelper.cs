using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace CustomTagHelperComponentTagHelperSample
{
    [HtmlTargetElement("footer")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class MyTagHelper : TagHelperComponentTagHelper
    {
        public MyTagHelper(IEnumerable<ITagHelperComponent> components, ILoggerFactory loggerFactory)
            : base(components, loggerFactory)
        {
        }
    }
}
