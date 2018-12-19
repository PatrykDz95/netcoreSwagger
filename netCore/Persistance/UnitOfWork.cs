using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netCore.Models;

namespace netCore.Persistance
{
    public class UnitOfWork : IDisposable
    {
        private ProductContext context = new ProductContext();
        private ProductRepository productRepository;


        public UnitOfWork()
        {
        }

        public ProductRepository ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new ProductRepository(context);
                }
                return productRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
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
