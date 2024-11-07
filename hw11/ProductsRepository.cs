using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    public class ProductsRepository : IProductsRepository
    {
        public void Add(Products product)
        {
            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                db.Execute(ProductsQueries.Create, new { product.Name, product.CategoryId, product.Price });
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                db.Execute(ProductsQueries.Delete, new { Id = id });
            }
        }

        public Products Get(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                return db.QueryFirstOrDefault<Products>(ProductsQueries.Get, new { Id = id });
            }
        }

        public List<Products> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                return db.Query<Products>(ProductsQueries.GetAll).ToList();
            }
        }

        public List<Categories> GettAllCatt()
        {
            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                return db.Query<Categories>(ProductsQueries.GetAllCat).ToList();
            }
        }

        public void Update(string name, int categorId, int price)
        {

            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                db.Execute(ProductsQueries.Update, new { Name = name, CategoryId = categorId, Price = price });
            }


        }
    }
}
