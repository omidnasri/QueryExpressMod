## Query Express
A small utility to query data in production environment. Query Express requires no installation and is packaged as a single 100KB executable. This is more than 300 times smaller than SQL Server Management Studio!

![Query Express Screenshot](/src/docs/images/screenshot.jpg?raw=true "Query Express Screenshot")

Features:
* Supports SQL Server and Oracle
* High performance for big result sets.
* Save and open `.sql` query files.
* Syntax Highlighting supported removed because it made some problems for unicode based characters.

Application needs .NET 4.5 installed to run on windows 7 or later.

### Source
Modification of QueryExpress (http://www.albahari.com/queryexpress.aspx) to upgrade to .NET 4.6.2 (still winforms) and add SQL syntax highlighting using FCTB (https://www.codeproject.com/Articles/161871/Fast-Colored-TextBox-for-syntax-highlighting).
