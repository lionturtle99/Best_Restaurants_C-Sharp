<h1 align="center">BestRestaurants</h1>

#### By: Liam Eller, Eric Crudup, & Daniel Lindsey

#### _Terminal based bakery_

## Technologies Used

* C#
* html
* Markdown
* CSS
* Razor
* ASP .NET Core
* ASP .NET Core MVC


## Description

_A terminal based application where you can order bread and pastry's from PierresBakery and get a price back_

## Setup/Installation Requirements

1. Clone this repository to your desktop.
2. Open your terminal.
3. Navigate to the downloaded project by typing "cd (name of the project)".
4. Run "code ." to open program in VSCode to edit or view code.
5. Navigate to the (name of the project) directory
6. type "dotnet build" then "dotnet run" to run application in your the terminal.

## Connection String

_Next, we need to add the database connection to our app. We'll do this using the connection string we currently have as a property of the DBConfiguration class in our Startup.cs file._

_Before we move forward with this, it's important to note that the file we are about to create will store sensitive information that we don't want to share with the world. As such, before we make any commits with it in our project, we should add this "*/appsettings.json" to our .gitignore:_

_Now we'll store the connection string in a new file called appsettings.json in the directory of our project's production folder, BestRestaurants/:_

#### Inside BestRestaurants/appsettings.json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
_Note that the database will change based on the database we are connecting to and that uid and pwd may vary as well depending on MySql configurations._
  
## To run tests
  
1 Navigate to the (name of the project) directory with the ".Tests" extension.
2 type "dotnet test" to see passing tests.

## Known Bugs

* No known bugs at this time.

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copyright (c) 2022 Liam Eller, Eric Crudup, & Daniel Lindsey


# NOTES:

* anything in the square brackets ( [] ) is inside the [Views] directory

1. landing page [Home/Index] options to navigate to [Cuisines/index] & [Restaurants/Index]
2. Add Cuisines page [Cuisines/Create.cshtml] options to navigate to a specific cuisine [Cuisines/Details] that shows all restaurants serving that cuisine 
3. Add 