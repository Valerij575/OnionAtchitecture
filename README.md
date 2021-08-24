# OnionAtchitecture

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
	
3. Create the MVC web application under UI.MVC folder and create new project on folder “CoreCleanArchitecture.Web”.