# Record Store

A C# program where a user can add Artists, Albums and Songs to a record store.
### Created by Aaron Boyd

## Technologies Used

* Git
* C#
* .NET 5.0
* MVC
* Razor
* Entity
* CSS
* SQL
* Design Time

## Description:
This project demonstrates CRUD functionality and Many-to-Many/One-to-Many relationships using Asp.Net Core, Entity and MySQL database. 

A user can add Artists, Albums and Songs. When a user adds a Song or an Artist they can associate it with an existing Album.

## Setup Installation Requirements

1. Clone the RecordStore repository
2. Open in your favorite IDE
3. CD into RecordStore
4. Ensure MySql workbench is installed on your machine. If needed, please visit this site to download and install: [MySQLWorkBench]("https://www.mysql.com/products/workbench/")

5. Create an appsettings.json
6. Add the following to your appsettings.json replacing the ```[YourDataBaseNameHere]``` and ```[YourPasswordHere]``` with your Database name and your password:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YourDataBaseNameHere];uid=root;pwd=[YourPasswordHere];"
  }
}
```
7. run "dotnet tool install --global dotnet-ef --version 5.0.1"
8. run "dotnet ef database update" to create the database schema from the previous migrations.
8. run "dotnet build"
9. run "dotnet run" to use the program
10. Enjoy!

# Known Bugs
None

## License Info
[MIT License](https://opensource.org/licenses/MIT)
Copyright 2022 (c) Aaron Boyd