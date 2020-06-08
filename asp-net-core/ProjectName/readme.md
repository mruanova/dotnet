# Getting Started

Setting up a web application with the ASP.NET Core framework is almost as simple as it was to build a console application. 

After navigating to where you'd like your project to be saved, we will use the web argument (instead of console) with our dotnet new command:

    dotnet new web --no-https -o ProjectName

What's with the --no-https?

By default, ASP will want to run your web applications using HTTPS. 

This is great for security, but will create some friction upfront - as you would need to then generate https certs for your local browsers. 

For now, it's best to turn this option off.

## Error Feedback

As we start developing more and more complex web apps, we will also start to encounter more errors and exceptions. 

Trying to resolve these issues without being provided any meaningful explanation would certainly be frustrating. 

The debugger can become even more useful as we try to follow the request-response cycle of a web app.

We also have another tool available to us, particularly for when we don't know where exactly our app is failing. 

To receive more explicit error messages about the state of our app, we just need to make sure our work environment is set to Development mode. 

Notice in the Configure method of our Startup file the following condition:

    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    
The default environment is Production mode, which is the version of our project we want our end users to see. We wouldn't want our users to see in plain text our erroneous lines of code (i.e. a Developer Exception Page), but we certainly want to see them!

To put our current work environment into Development mode, we need to change an environment variable for .NET.

## Windows

### Command Line

    setx ASPNETCORE_ENVIRONMENT Development

### PowerShell

    [Environment]::SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT","Development","User")

### macOS/Linux

    export ASPNETCORE_ENVIRONMENT=Development

After changing any environment variables, you should always restart any terminals you have open (including VS Code). 

Now on our local machine, we'll always be running in development mode and be able to see the Developer Exception Pages. 

When we are ready to deploy our application, we'll want to make sure the hosting server is set to Production mode.

### Dotnet Watch

One more helpful tool is the Dotnet Watcher. 

Running our application with this tool tells our project to automatically rebuild and run after we make changes to our .cs files. 

Though not crucial, this tool can save us some time during our learning experience.

To run the Watcher tool, simply run:

    dotnet watch run

Note: Even though the Watcher is running, it may still take a few seconds for your project to rebuild after a change.

## Adding MVC

We now have a working web server that is able to display text like "Hello World" on the web! 

The problem ends up being that all of our logic continues to live in the Program.cs and Startup.cs files. 

As we continue to grow our web applications this system simply is not going to work as these files would quickly become unwieldy. 

To combat this early, we are going to add the MVC structure to our applications! 

MVC will allow us to break out different components of our app into nicely sectioned class-based files. 

Lucky for us, ASP.NET Core was built very much with MVC in mind!

Do you remember where we go to configure our application? In the Startup class, we'll need to do two things to configure this piece of middleware. 

First, we need to tell our application that we'll be using the MVC service (more on services later!). 

Then we need to tell it when we want to actually use that service:

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();  //add this line
    }
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        // some code removed for brevity
        app.UseMvc();   //add this line, replacing the app.run lines of code
    }

As with any framework, if we want to use it, we have to follow its rules. 

The rest of this chapter will go over the different pieces we need for the ASP.NET Core MVC framework to function as intended.

## Services and Dependency Injection

### Overview

It is now time to better understand all that is going on inside of our Startup class's ConfigureServices method, which is, in fact, a central aspect of how this framework is wired. Every time we add a new line to this method, with something like:

    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }

we are adding a so-called "service" into our application's Service Container, seen here as IServiceCollection. 

This makes the specified service available to the rest of your application in a number of ways. 

In this example here, we are simply saying that our app wants to make use of the framework-provided MVC services, which, by and large, are handled internally by the framework itself to make the whole thing go. 

This entire system, in fact, utilizes a programming design-pattern known as dependency injection, which can be used alongside another design-pattern you are already familiar with (OOP).

### Dependency Injection

The basic premise of dependency injection is that rather than make tightly-coupled associations between classes using inheritance, you can provide objects that any class might need, known here as services, to a shared container, and anytime a class requires one of these services, you can inject that object into the class. 

Now what does this all actually look like in your code? You can use a type of DI, called Constructor Injection, to bring any service into your class by accepting an object of the desired service type into the Constructor method of that class.

To see an example of this, let's bring a service into our Startup class's constructor. 

One you will be working with soon is a framework-service called IHostingEnvironment, which is an object that will tell you more about the machine that is hosting the application. 

While in development, this will be your local PC; when you deploy, this will be a remote web server.

    public class Startup
    {
        // other code in Startup
        public Startup(IHostingEnvironment env)
        {
            // run this in the debugger, and inspect the "env" object! You can use this object to tell you // the root path of your application, for the purposes of reading from local files, and for
            // checking environment variables - such as if you are running in Development or Production
            
            Console.WriteLine(env.ContentRootPath);
            Console.WriteLine(env.IsDevelopment());
        }
    }

Read more about Dependency Injection is ASP.NET Core from the official Microsoft docs!

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.0

https://docs.microsoft.com/en-us/aspnet/core/migration/22-to-30?view=aspnetcore-2.2&tabs=visual-studio#update-routing-startup-code

