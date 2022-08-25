# Record Store

A C# program where a user can add songs and albums to a record store.
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

## Description:
This project demonstrates CRUD functionality and a One-to-Many relationship using Asp.Net Core, Entity and MySQL database. 

A user can add Albums and Songs. When a user adds a Song they can associate it with an existing Album.

## Snapshot

![Home View](RecordStore.Solution\RecordStore\wwwroot\img\home-index.png)

## Setup Installation Requirements

1. Clone the RecordStore repository
2. Open in your favorite IDE
3. CD into RecordStore
4. Ensure MySql workbench is installed on your machine. If needed, please visit this site to download and install: [MySQLWorkBench]("https://www.mysql.com/products/workbench/")

5. Import the record_store_dump.sql file into MySql Workbench:
- Save the file to your desktop
- In the Navigator > Administration window, select Data Import/Restore.
- In Import Options select Import from Self-Contained File.
- Navigate to the sql file you just saved to your desktop.
- Under Default Schema to be Imported To, select the New button.
- Enter the name of your database and remember this name for your appsettings.json file.
- Click Ok.
- Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
- After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The database will appear.

6. Create an appsettings.json
7. Add the following to your appsettings.json replacing the ```[YourDataBaseNameHere]``` and ```[YourPasswordHere]``` with your Database name and your password:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YourDataBaseNameHere];uid=root;pwd=[YourPasswordHere];"
  }
}
```
8. run "dotnet build"
9. run "dotnet run" to use the program
10. Enjoy!

# Known Bugs
None

## License Info
[MIT License](https://opensource.org/licenses/MIT)
Copyright 2022 (c) Aaron Boyd