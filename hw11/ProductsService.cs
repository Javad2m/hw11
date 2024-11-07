using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hw11;

public class ProductsService : ProductsRepository
{

    public void Creat(string name, int cid, int price)
    {
        try
        {
            var products = GetAll();
            bool isExistence = products.Any(s => s.Name == name);
            if (isExistence)
            {
                Console.WriteLine("There is a product with this name!");
                return;
            }
            if (cid < 1 || cid > 4)
            {
                Console.WriteLine("There is no selected category");
                return;
            }
            var newProduct = new Products
            {
                Name = name,
                CategoryId = cid,
                Price = price,
            };
            Add(newProduct);
            Console.WriteLine("The product was created successfully");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");

        }
    }

    public string GetCategoriesName(int cid)
    {
        try
        {
            var categories = GettAllCatt();
            var cat = categories.FirstOrDefault(s => s.Id == cid);
            return cat.Name;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }


    }

    public void ProductsList()
    {
        try
        {
            var products = GetAll();
            foreach (var pr in products)
            {
                Console.WriteLine($"Name: {pr.Name} - Price: {pr.Price} - Categories: {GetCategoriesName(pr.CategoryId)}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");

        }

    }


    public void GettId(int id)
    {
        var pr = Get(id);
        Console.WriteLine($"Name: {pr.Name} - Price: {pr.Price} - Categories: {pr.CategoryId}.{GetCategoriesName(pr.CategoryId)}");
    }

    public void UpdatePr(int id, string name, int ci, int price)
    {
        try
        {
            if (ci < 1 || ci > 4)
            {
                Console.WriteLine("There is no selected category");
                Console.ReadKey();
                return;
            }
            var pr = Get(id);
            pr.Name = name;
            pr.CategoryId = ci;
            pr.Price = price;
            Update(pr.Name, pr.CategoryId, pr.Price);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.ReadKey();
        }

    }

    public string getName(int id)
    {
        var pr = Get(id);
        return pr.Name;

    }


    public void DeletPr(int id)
    {
        try
        {
            var pr = Get(id);
            if (pr != null)
            {
                Delete(id);
                Console.WriteLine("Done");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Id Incorcct");
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.ReadKey();
        }



    }

}
