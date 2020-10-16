# _Dr SillyStringz Factory_

#### _C# ASP.NET MCV w/ MySQL Project for Epicodus, October 16th, 2020_

#### By _** Daniel Schaaf **_

## Description

This Project was to show my understanding of many to many relationships. this project had us take three classes and show to to make them into a many to many relationships. here is my brainstorming chart that i used to create my database


###Brainstorming

<h1 align='center'><img width='600' height='450' src='images/chart.PNG'>
 
### Specs
| Spec | |  |
| :-------------     | :------------- | :------------- |
|  1.  Create License,Machine and Engineer Classes | | |
|  2.  Build License Controllers for Index, Create, Delete, Details, Edit |  |  |
|  3.  Build Machine Controllers for Index, Create, Delete, Details, and Edit | ||
|  4.  Build Engineer Controllers for Index, Create, Delete, Details, and Edit | ||
|  5.  Build Home Controllers for Index |  |  |
|  6.  Build Home Views for Index |  |  |
|  7.  Build Machine,Engineer and License Views for Index, Create, Delete, Details,AddEngineer,AddLicense | |  |
|  8.  Add Links to Clients Class and HTML |  |  |
|  9.  Add CSS and Styling |  |  |


## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Make Engineers,Licenses and Machines

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Make Engineers,Licenses and Machines

### Database Setup

*setup with database update
* run dotnet ef database update and it will build out your database.

* Setup with SQL Import
  * MySQL
    * In the Navigator > Administration window, select Data Import/Restore.
    * In Import Options select Import from Self-Contained File.
    * Navigate to daniel_schaaf.sql.
    * Under Default Schema to be Imported To, select the New button.
      * Enter 'daniel_schaaf' as the name of your database.
      * Click Ok.
    * Click Start Import.
  * Go to appsettings.json and change the password if needed.

## Known Bugs

Built the program under the wrong root folder.

## Technologies Used

Main Programs
* MySQL
* C# / ASP.NET Core 
* MVC
* CSS
* Bootstrap


### Other Links
[Daniel's GitHub](https://github.com/dschaaf89)

### License

Copyright (c) 2020 **_{ Daniel Schaaf}_**
Licensed under MIT
