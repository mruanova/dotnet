# mau dot net core

    dotnet new mvc  --no-https -o MauDotNetCore

## entity framework core

    dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0

    dotnet add package Pomelo.EntityFrameworkCore.MySql 

    dotnet tool install --global dotnet-ef

    dotnet add package Microsoft.EntityFrameworkCore.Design

## Code First Database Creation

Up until now, we've had to manually create our databases to match our models. 
But Entity Framework provides us with a tool that allows us to create database tables directly from our models! 
EF can read our model files to create "migrations", files that contain instructions for the database to create or modify tables.

### Migrations
Migrations are an extremely powerful tool for interacting with your database.  
Any time we change our models we can create new migrations to update the database accordingly, but be warned, you may have to delete your existing table data if it doesn't conform to the new model structure.

Migrations are created using the Entity Framework command line tools. From the console we can create migrations like so:

    dotnet ef migrations add YourMigrationName

Let's create an initial migration:
    
    dotnet ef migrations add InitialCreate

After this code finishes executing you should see a new folder called "Migrations":

With the migration file created, all that's left is to apply it to the database. We do this with another console command:

    dotnet ef database update

dotnet ef database update  takes our migration file and applies it to the database, performing the actual creation of the tables. 

The name of the tables we create is determined by the name we give to their corresponding  DbSet  field in our Context class, not the name of the model they correspond to. 

(Convention dictates that the names of these tables is the plural of your Model.)

### A couple notes on troubleshooting:

If you change your database significantly, it's possible that you'll receive errors when you try to run your updates. 

If you're having trouble, a guaranteed solution is to drop your tables, delete all of your migrations, and generate a new migration. 

You will lose all of your data, but this will solve any migration conflicts you may have.

If you receive an error that your build failed when adding your migrations, you can try running your command again with a -v at the end.

This stands for "verbose" mode, and will give you a detailed rundown of what went wrong in your migration, including where the problem was!
