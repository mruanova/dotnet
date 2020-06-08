# Getting Started

Setting up a web application with the ASP.NET Core framework is almost as simple as it was to build a console application. 

After navigating to where you'd like your project to be saved, we will use the web argument (instead of console) with our dotnet new command:

    dotnet new web --no-https -o ProjectName

What's with the --no-https?

By default, ASP will want to run your web applications using HTTPS. 

This is great for security, but will create some friction upfront - as you would need to then generate https certs for your local browsers. 

For now, it's best to turn this option off.

