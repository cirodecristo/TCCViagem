$strconn = "Data Source=" + $args[0] + ";Initial Catalog=" + $args[1] + ";Integrated Security=True"
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.10
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.10
dotnet tool install --global dotnet-ef
dotnet ef dbcontext scaffold $strconn Microsoft.EntityFrameworkCore.SqlServer --force -o Model
 