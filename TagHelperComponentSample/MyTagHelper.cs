using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace CustomTagHelperComponentTagHelperSample
{
    [HtmlTargetElement("footer")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class MyTagHelper : TagHelperComponentTagHelper
    {
        public MyTagHelper(ITagHelperComponentManager manager, ILoggerFactory loggerFactory)
            : base(manager, loggerFactory)
        {
        }
    }
}
