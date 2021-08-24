# OnionAtchitecture
## Blank Solution
1. Create Blank Solution with name CleaneArchitecture
2. Create the folders which we will use to store individual projects:
	- CoreCleanArchitecture.UI.MVC
	- CoreCleanArchitecture.Application
	- CoreCleanArchitecture.Domain
	- CoreCleanArchitecture.Infrastructure.Data
	- CoreCleanArchitecture.Infrastructure.Ioc
	- CoreCleanArchitecture.Tests
	
	Application will take care of our interfaces, services, business rules.
	Domain consists of Entities
	Data knows about how to access our data
	IoC (Inversion of Control) will help us to dependency injection.
	
	![SolutionArchitecture](https://user-images.githubusercontent.com/37914930/130619922-6cf95db7-285d-4eaf-bce5-1a5ab478ae20.png)
	
3. Create the MVC web application under UI.MVC folder and create new project on folder “CoreCleanArchitecture.Web”.

## Create Identity Database using Migration:

1. Configure our database connection and it will create database for identity using core first approach. 
   As below open “appsettings.json” and edit you connection string.
   ```
   “ConnectionStrings”: {
	“DefaultConnection”: “Server=DESKTOP-JKRRO7I;Database=aspnet-CoreCleanArchitecture.Web-75CCCCEC-3C58–4A33–9B36-FE792EA54795;Trusted_Connection=True;MultipleActiveResultSets=true”
	}

2. Open Package Manager Console from the Tools Menu and select the Default project for which you would like to generate migrations code
3. For creating the migration code, we use ‘add-migration MigrationName’ command.
4. Execute ‘update-database’ command for update Database. Us you can see you database also created on SQL server.
	![Database architecture](https://user-images.githubusercontent.com/37914930/130621677-e5b450e2-fe12-4531-ad02-545460e9a2ba.png)


## Domain
1. Add a Class Library project to our domain layer which will hold the core entities.
2. Add a new folder Models (or Entities), for the sake of this article let’s assume we are building a library system
3. Add Project model to the Models folder.

## Infrastructure
Create a new database context so we can update the database with this new model. We will be doing it in our Infrastructure layer. 
1. Add new class library called CleanArchitecture.Infra.Data and under that folder named Context.
2. Add database context ProjectDbContext 
3. Add Domain Project referece to Infrastructure project
4. install Following all as same as above steps:
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Design
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.Tools
5. configure this new DbContext in Startup.cs of UI project. Add following lines to ConfigureServices method.
	```
	services.AddDbContext<ProjectDbContext>(options => 
                options.UseSqlServer(
                    Configuration.GetConnectionString("ProjectConnection")));
6. execute add-migration
	```
	Add-Migration InitMigration -Context ProjectDbContext
	```
	![InfrastructureDbContext](https://user-images.githubusercontent.com/37914930/130662536-77e348c3-abcb-434d-9c19-5602414f8b48.png)
   and update-database -Context ProjectDbContext
   Add update-database command executes successfully, you will received message for “Done” and you can see you database also created on SQL server.
   
  ## Application Core
  All of our services, interfaces and ViewModels will go here.
  
  1. Create a new Class Library (.NET Core) - CleanArchitecture.Application
  2. Add following folders on project CleanArchitecture.Application:
  	- Interfaces
  	- Services
  	- ViewModels
  	A view model represents the data that you want to display on your view/page, whether it be used for static text or for input values (like textboxes and dropdown lists) that can be added to the database (or edited). It is something different than your domain model. It is a model for the view. In other words, it creates a mask for the domain models.
  3. Create a new class under ViewModels folder named ProjectViewModel. For the time being we will get a list of Products from the database. 
  4. Create a new interface to act as a contract to the functionality that we’re trying to implement. 
  	This method will return list of Projects, and it only knows about the ViewModel, not about the core domain model Project, so we are abstracting the core entity by doing this, rather than having everything in one place.
	
  Before we write the implementation for IProjectService, we have to define a way to get the data from the database, to do that what we normally use in .NET is an ORM called Entity Framework, but we will use the Repository pattern to decouple the business logic and the data access layers in our application.
  The Repository Design Pattern in C# Mediates between the domain and the data mapping layers using a collection-like interface for accessing the domain objects. In other words, we can say that a Repository Design Pattern acts as a middleman or middle layer between the rest of the application and the data access logic.
	
   5. Add another folder called Interfaces under CleanArchitecture.Domain project. Add a new interface named IProjectRepository.cs.
   6. Under CleanArchitecture.Application project, under services folder, add a new class, ProjectService.cs, and inherit it from IProjectService.
   7. Implement ProjectRepository under CleanArchitecture.Infra.Data Project with Create new Repositories Folder and create new class with name “ProjectRepository” under this new Repositories Folder.
   8. Now we need to inject the I ProjectRepository, Inject it as you would normally do dependency injection in .NET.
