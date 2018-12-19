using System;
using System.Collections.Generic;
using System.Linq;
using netCore.Models;
using Microsoft.EntityFrameworkCore;

namespace netCore.Persistance
{
    public class ProductRepository : IProductRepository, IDisposable 
    {
        //DbSet<Product> dbSet;
        internal ProductContext context;
        internal DbSet<Product> dbSet;


        public ProductRepository(ProductContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Product>();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbSet.ToList();
        }

        public Product GetProduct(int id)
        {
            return dbSet.Find(id);
        }

        public void InsertProduct(Product tentity)
        {
            dbSet.Add(tentity);
        }
        public void DeleteProduct(int id)
        {
            Product product = context.Products.Find(id);
            dbSet.Remove(product);
            
        }
        public void UpdateProduct(Product tentity)
        {
            dbSet.Attach(tentity);
            context.Entry(tentity).State = EntityState.Modified;
        }      

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
