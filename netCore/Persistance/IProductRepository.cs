using System;
using System.Collections.Generic;
using netCore.Models;

namespace netCore.Persistance
{
    interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        void InsertProduct(Product product);
    }
}
