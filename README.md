# Robert_Freid_Final_Project
### Create and develop a ASP.NET Web API program in conjunction with Contemporary Programming Class Requirements.
Develop a ASP.NET WebAPI, using Git as a code repository. <br>
The WebAPI should conform to the following specifications. <br>
* Use latest version of dotnet (6 or newer)
* Connect to a database using Entity Framework Core - Code First Approach
* The API should consist of four controllers. Each attaching to its own table. <br>
At least one of the tables should consist of the following information: <br>
* Team member full name
* Birthdate (datetime)
* College Program
* Year in program: Freshman, Sophomore, etc.
<br>
Create 3 other tables are your choice. Hobby, favorite breakfast foods, etc. Foreign key relationships not needed. But each table must consist of at least 5 columns, including the primary key column.
<br>
Each Controller should consist of all CRUD operations to interact with the underlying table (Create, Read [single or multiple, see below], Update, Delete).
<br>
The Read operation for each method should take in a nullable id (int). If null or zero is provided for the id, return the first five results from the table. 
<br>
* Use NSwag package library as a means to view each controller and its actions
<br>
* EXTRA CREDIT: Run your program in Azure. Note, you will need to import both your database, as well as your code into Azure and develop a pipeline. We will cover that next week.
<br>
**UC does not allow me to access Micrososft Aaure as part of being a student. I have to use what resources I have.**
<br>
Note: Follow Acceptance Criteria for each assignment. Incomplete Acceptance Criteria will not be graded and need to be re-submitted with a late penalty attached.

