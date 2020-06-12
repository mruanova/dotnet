# mvc

dotnet new mvc -o DojoSurvey

## MVC Templates

In addition to dotnet new web, you have some other options for creating project templates. 

When first learning, it has been good to build MVC projects from a base web application, but we can now make use of templates that do some of the boilerplate work for us.

    dotnet new mvc

This template creates a fairly large MVC project template, with some interesting - if heavy - defaults. 

You may also run this template command with the --no-https flag.

## watch

	dotnet watch run

## Routes

https://localhost:5001/

https://localhost:5001/user

https://localhost:5001/student

https://localhost:5001/survey

## mysql

In terminal after navigating to your project directory, run the following commandscopy

	dotnet add package MySql.Data -v 8.0

	mysql -u root -p

	show databases;

	use friendsdb;

	describe users;

	INSERT INTO friends (Name) VALUES ("mau");

## dapper

	dotnet add package Dapper

### Deployment with Dapper

At this point, it should be no surprise that deployment with Dapper is no different than what we have been doing in the past. 

This is great for us, but there are a few things we should reiterate. 

The goal at this point is to deploy the app we have just built. 

There are quite a few sensitive parts of this app that we should take note to secure!

Move things like API keys and database connection strings away from your public files and into something more like appsettings.json or secrets

Make sure you do not push your appsettings.json file out somewhere public

Have all validations on models generated from input fields and test them

Include a check for Antiforgery Token and add it to your forms or use tag helpers (done by default with tag helpers)

Make use of the bind keyword for post routes as to avoid "re-posting"

Make sure users have proper permissions to any sensitive routes on your site (admin pages) they may access or else immediately display a 404 status error
