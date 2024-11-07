using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11;

public static class ProductsQueries
{
    public static string Create = "insert into Products (Name, CategoryId, Price) values (@Name, @CategoryId, @Price);";
    public static string Get = "SELECT * FROM Products WHERE Id = @Id";
    public static string GetAll = "SELECT * FROM Products";
    public static string GetAllCat = "SELECT * FROM Categories";
    public static string Delete = "delete Products Where Id = @Id ";
    public static string Update = "UPDATE Products SET Name = @Name, CategoryId = @CategoryId, Price = @Price WHERE Name = @Name";

}
