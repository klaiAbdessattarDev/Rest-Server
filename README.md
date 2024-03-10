
## Description
 REST server
- 	A small REST server with good performance for simple customer management has two functions:
 1. Post Customers
 2. Get Gestomers

Multiple customers can be sent in one request.
The server validates every customer of the request:
- checks that every field is supplied
- validates that the age is above 18
- validates that the ID has not been used before

The server then adds each customer as an object to an internal array – the customers will not be
appended to the array but instead it will be inserted at a position so that the customers are
sorted by last name and then first name WITHOUT using any available sorting functionality (an
example for the inserting is in the Appendix).
The server also persists the array so it will be still available after a restart of the server.

## 🛠 Skills
c# 
.Net 5 
RESTful API 

The CustomersController class is a controller,it has methods for handling HTTP requests to add customers and retrieve the list of customers
The code uses the Newtonsoft.Json library to serialize and deserialize the list of customers to and from a JSON file.
The code follows the best practices of using dependency injection, separating concerns into separate classes and interfaces, and handling exceptions appropriately. It also uses the BinarySearch method of the List class to efficiently find the insertion point for a new customer in the sorted list of customers.

## 🚀 About Me
I'm a senior ,net software engineer, I have over seven years of experience in developing web solutions using .NET technologies, such as ASP.NET MVC, Web aPI, Razor, Entity Framework, SQL Server, JavaSCript, Jqury, TypeScript,Azure DevOps.

I enjoy taking on challenging projects that require creativity, collaboration, and quality assurance. I follow clean code best practices, conduct code reviews, and write unit and integration tests using NUnit and Pact. I also have experience in front-end development with Razor and KnockoutJs, and in working with Postgresql and SQL Server databases. My goal is to deliver reliable, scalable, and user-friendly solutions that meet the needs of the clients and the users....

- Linkedin : https://www.linkedin.com/in/abdessattar-klai-devweb/
- Github : https://github.com/klaiAbdessattarDev/