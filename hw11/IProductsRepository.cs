using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    public interface IProductsRepository
    {
        public void Add(Products user);
        public List<Products> GetAll();
        public Products Get(int id);
        public void Update(string name, int categorId, int price);
        public void Delete(int id);
    }
}
