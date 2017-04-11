# TagHelperComponent Sample

This is an example of how to modify the [HeadTagHelper](https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Razor/TagHelpers/HeadTagHelper.cs) and the [BodyTagHelper](https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Razor/TagHelpers/BodyTagHelper.cs) in ASP.NET MVC 2.0.

To get started, [download Visual Studio 2017](https://www.visualstudio.com/downloads/)

Clone the repository and open the TagHelperComponentSample.sln

In the `MyTagHelperComponent.cs` file, change the `TagHelperOutput` to modify the `<head>` or `<body>` HTML element any way you want.

To learn more, head to [Channel 9](https://channel9.msdn.com/). A video tutorial will be posted soon!


### Before ASP.NET MVC 2.0 RTM later this year

To get started, [download Visual Studio 2017](https://www.visualstudio.com/downloads/), and create a new ASP.NET Core Web Application project

![FileNewProject](https://github.com/jbagga/TagHelperComponentSample/blob/master/images/FileNewProject.png)

![.NETCoreWebApp](https://github.com/jbagga/TagHelperComponentSample/blob/master/images/.NETCoreWebApp.PNG)

![WebApp](https://github.com/jbagga/TagHelperComponentSample/blob/master/images/WebApp.PNG)


## Acquire ASP.NET Core 2.0 bits
### Add a NuGet.config file to the root level of your solution:

![SolutionFolder](https://github.com/jbagga/TagHelperComponentSample/blob/master/images/SolutionFolder.PNG)

You can use the `NuGet.config` file in the sample above.

### Use the NuGet feed with these bits

1. Right-click the project and open the Manage NuGet Packages... dialog

2. Change the Packages source to AspNetCore

3. Under the Updates tab:

* Check the "Include prerelease" checkbox

* Check the "Select all" checkbox

4. Press Update

![ManagePackages](https://github.com/jbagga/TagHelperComponentSample/blob/master/images/UpdatePackages.png)

You now have the latest bits to use `TagHelperComponent` and related classes.









