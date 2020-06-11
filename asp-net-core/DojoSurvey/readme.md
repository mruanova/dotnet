# mvc

dotnet new mvc -o DojoSurvey

## MVC Templates
In addition to dotnet new web, you have some other options for creating project templates. 

When first learning, it has been good to build MVC projects from a base web application, but we can now make use of templates that do some of the boilerplate work for us.

    dotnet new mvc

This template creates a fairly large MVC project template, with some interesting - if heavy - defaults. You may also run this template command with the --no-https flag.

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

