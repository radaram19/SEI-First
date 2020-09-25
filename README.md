# SEI-First
1. The first command generates our API, which is the point of access for our application.
2. Generally, We can create BO, DAL and BAL as seperate projects and an interface to use the API. However, based on limited time I have created in the same API.
3. In this API, created folders for Bussiness Objects, data access layer and bussiness acess layer.
4. The second generates our Core library. This is our application’s foundation, it will hold our contracts (interfaces, …), our models and everything else that is essential.
5. The third is for our Services layer. This is where we will implement business logic.
6. And the last is our Data access layer where we will connect with data providers (SQL Server).
7. Core layer: As said before, this will be the home of our Models, our interfaces and so on.
8. In thisFirst we create a folder called Models to hold our models, 
9. We can begin by define our Product.cs model. It has a 1:n relationship with ProductContext.cs model.
10. The Repository pattern, is encapsulating our database operations (ORM or other methods of database access) in one place. Basically abstracting your data access layer.
11. There are many uses usign repository pattern such as Reusablity, Testability, Separation of concerns and Decouled the code.
12. Handled all the razor pages in Pages folder.
13. Services will be the center of our business logic, the link between our API and our Data.
14. First we create a folder to house our services interfaces, the SEI.BAL folder.
15. Then create service interfaces, IProductService.cs, to handle ProductDetails logic.
16. Data Access layer, Persistence layer is very important to communicate with our database. 
15. We can use Entity Framework, Object Relation Model (ORM) which basically maps all database tables and columns to C# objects, making it easy to manage data and run queries.
later we can excute EF with the command.
16. We need to add the necessary dependancies to our project, such as EFcore,  EF design, EF sqlserver.
17. Then we need to configure the Product.cs These we can configure directly in DbContext.
18. Now, we can create a ProductContext and add our Dbsets to the respective tables.
19. We can create Repositories to our project and implement base Repository so that we can have an interface with our DbContext.
20. Later we can add dependancy Injection to our application knows that we use repository interfaces implementations. Third DI in the API project statrtup.cs by adding ConfigureServices method.
21. Then we need a connectionString to our API to use it. In appsettings.Development.json and the conncetionStrings.
In this we need to add server, database, admin right like username and password. 
22. Now we can run the application  seed some data to our database. Now we can make the requests to our database then it wll come to services make all the operations to bring our logic to presentaion layer.
