Due to using NET6.0 version install packages with PROPER version (not latest)
	- Microsoft.EntityFrameworkCore (6.0.21);
	- Microsoft.EntityFrameworkCore.SqlServer (6.0.21);
	- Microsoft.EntityFrameworkCore.Tools (6.0.21);

Clean and rebuild solution;

Migrate Db PM console command:
	- Add-Migration Initial (rollback -> Remove-Migration )
	- Update-Database

Check the data in database using SQL Server Management Studio.

Install packages for GraphQL:
	- HotChocolate.AspNetCore
	- HotChocolate.Data.EntityFramework

Debug:
Endpoint: https://localhost:7152/graphql
Query example:

    query {
        getSuperheroes(order: {height:DESC}){
            name
            description
            height
            superpowers{
                superPower
                description
            }
            movies{
                title
                releaseDate
            }
        }
    }
