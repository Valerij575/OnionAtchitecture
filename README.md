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
	
	![SolutionArchitecture](https://user-images.githubusercontent.com/37914930/130619922-6cf95db7-285d-4eaf-bce5-1a5ab478ae20.png)
	
3. Create the MVC web application under UI.MVC folder and create new project on folder “CoreCleanArchitecture.Web”.
