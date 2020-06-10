# mvc

dotnet new mvc -o DojoSurvey

## MVC Templates
In addition to dotnet new web, you have some other options for creating project templates. 

When first learning, it has been good to build MVC projects from a base web application, but we can now make use of templates that do some of the boilerplate work for us.

    dotnet new mvc

This template creates a fairly large MVC project template, with some interesting - if heavy - defaults. You may also run this template command with the --no-https flag.

### Removing Cookie Consent Policy
One thing you will want to do with all of your projects using the dotnet new mvc template will be cleaning out some default configurations regarding Cookie Consent Policy. 

Essentially, these templates will - by default - restrict the storage of your user's cookies until they approve. 

Both the configuration of this policy, as well as the Consent Partial (default HTML for your users to approve of this policy), are included in the default MVC template. 

The reason we are doing this is that without this step, session data will not be reliably stored and accessed.

Remove the following lines from your Startup.cs file
```
services.Configure<CookiePolicyOptions>(options =>
{
	// This lambda determines whether user consent for non-essential cookies is needed for a given request.
	options.CheckConsentNeeded = context => true;
	options.MinimumSameSitePolicy = SameSiteMode.None;
});

app.UseHttpsRedirection();
app.UseCookiePolicy();
```
Remove the following line from your _Layout.cs file
```
<partial name="_CookieConsentPartial"></partial>    
```
The next section will walk through some of those defaults, and the framework features those defaults are utilizing.

## Generated Files
There are nifty features that dotnet new mvc makes use of that you will want to know more about. 

Notably, these templates make use of a "Layout" file that you can use to serve as a master HTML document and can house the various Views you are serving from your Controllers. 

This means you only need to define a complete HTML document one time, and keep your other View files lean.

## Layout File
Most web apps have a common layout that provides the user with a consistent experience as they navigate from page to page. The layout typically includes common user interface elements such as the app header, navigation or menu elements, and footer. 

Common HTML structures such as scripts and stylesheets are also frequently used by many pages within an app. 

All of these shared elements may be defined in a layout file, which can then be referenced by any view used within the app. Layouts reduce duplicate code in views, helping them follow the Don’t Repeat Yourself (DRY) principle. 

By convention, the default layout for an ASP.NET app is named _Layout.cshtml; and our mvc template includes a fairly robust layout file in the Views/Shared folder for you. In this default template, both Bootstrap and jQuery are loaded, as well as a common css (site.css) and javascript (site.js) file for you to use. Feel free to remove any elements you don't wish to use. In addition to the default elements, you may place any HTML you want shared throughout your project's views. You can even have multiple layouts which can be cycled through or used on different sections of your app. Another file related to the Layout that our mvc template generates _ViewStart.cshtml is where the current active Layout for views is set.

The _Layout.cshtml file that our mvc template generates for us looks something like this:
```
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>MyCoolProj</title>
    <!-- css / js imports removed for brevity -->
</head>
<body>
    <div class="container">
        @RenderBody()
    </div>
    
</body>
</html>
```
Take special notice of the @RenderBody() line. Whenever our app returns a View, it first renders this layout file, then our view file is rendered in place of @RenderBody() . Because of this our views never need their own <html>, <head>, or <body> tags and also don't need their own link to our site.css . We can also modify _Layout.cshtml to include any elements that we want to appear on every page of our app, like a Header or a link to the Home page.

ViewStart
In the Views folder of our generated project there is a file called _ViewStart.cshtml . 

This ViewStart file is run before any view is rendered. When our mvc template generates this file all it does is ensure that the default Layout is used by all views. 

You may have as many layout files as you wish, for example maybe you want views in your DashboardController to share a navbar. 

You can add a ViewStart file to Views/Dashboard, and set Layout to a Layout file that has a navbar. ASP's view-finding system will prioritize views in a controller's view directory over Shared/, so you won't have to worry about conflicting with the master Layout in Views/Shared.

ViewImports
Alongside the ViewStart file you should also find a file called _ViewImports.cshtml . 

ViewImports is used to import any additional packages or namespaces that are needed by multiple views. 

The default _ViewImports.cshtml created by our mvc template brings in our project namespace with a using statement and activates some additional Razor functionality. 

You can bring in additional namespace references to this file as well, making the classes they contain available to your views without an explicit path. 

To do this, simply add another line:

    // _ViewImports.cshtml
    @using MyCoolProj.AnotherNamespace

## Tip!

Both _ViewStart and _ViewImports can be generated with the dotnet new command, with dotnet new viewimports and dotnet new viewstart. 

This is useful if you wish to start new projects with the more lightweight dotnet new web template. 

These will be placed wherever you run the command from in your terminal - which more than likely, will be in your project's working directory. 

Since these files will want to go in your Views/ directory, you can use the -o flag to specify a location. 

So you can run:

    dotnet new viewimports -o Views
    // and
    dotnet new viewstart -o Views

To place them in the appropriate directory.
