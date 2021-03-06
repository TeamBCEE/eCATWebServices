# eCAT Web Services
### About
The EPME Course Application Toolkit Webservices provides backend support for companion client web applications. 

### Requirments
The following is a list of requirements for development of the eCAT Webservices project.

##### Development Environment
* .Net 4.6
*  Asp.Net Core 1
*  Visual Studio 2017 (current at RC1)
*  SQL Server 

##### Dependencis
eCAT Webservices development dependencies are managed by [Nuget](https://www.nuget.org/), access to the nuget and microsoft sites are needed in order to download the following list of major packages:
* Entity Framework v6.1.3 (ORM for SQL Server)
* Breeze Server [(Client/Server Data Managment)](http://breeze.github.io/doc-net/)
* OpenAuthenication [()]()

##### Database Configuration
To enable Db Migration
1. `Enable-Migrations -MigrationsDirectory {Directory Name} -StartUpProjectName Ecat.DataLib -ContextTypeName Ecat.DataLib.Context.{Context Name}`
2. `Add-Migration -StartUpProjectName Ecat.DataLib -ConfigurationTypeName Ecat.DataLib.{Context Name}.Configuration -Name {Subtle Name}`
3. `Update-Database -StartUpProjectName Ecat.DataLib -ConfigurationTypeName Ecat.DataLib.{Context Name}.Configuration`