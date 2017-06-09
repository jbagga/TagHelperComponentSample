# TagHelperComponent Sample

This is an example of how to modify the [HeadTagHelper](https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Razor/TagHelpers/HeadTagHelper.cs) and the [BodyTagHelper](https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Razor/TagHelpers/BodyTagHelper.cs) in ASP.NET MVC 2.0.

To get started, [download Visual Studio 2017](https://www.visualstudio.com/downloads/) and [.NET Core 2.0.0 preview1](https://www.microsoft.com/net/core/preview#windowscmd).

Clone the repository and open the TagHelperComponentSample.sln

In the `MyTagHelperComponent.cs` file, change the `TagHelperOutput` to modify the `<head>` or `<body>` HTML element any way you want.

To learn more, head to [Channel 9](https://channel9.msdn.com/). A video tutorial will be posted soon!

# Custom TagHelperComponentTagHelper Sample

This is an example of how to create a custom `TagHelperComponentTagHelper` similar to the [HeadTagHelper](https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Razor/TagHelpers/HeadTagHelper.cs) and the [BodyTagHelper](https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Razor/TagHelpers/BodyTagHelper.cs) in ASP.NET Core MVC 2.0.

In the `MyTagHelper` file, change the `[HtmlTargetElement]` to any HTML element of your choosing like the `<p>` or `<script>` tags. The sample uses `<footer>` as an example, to modify all `<footer>` tags in the application.

In the `MyTagHelperComponent.cs` file, change the `TagHelperOutput` to modify the `<head>` or `<body>` or the HTML element of your choice (the one you created in the step above) any way you want.

To learn more, head to [Channel 9](https://channel9.msdn.com/). A video tutorial will be posted soon!










