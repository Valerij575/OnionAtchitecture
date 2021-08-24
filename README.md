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
