using Microsoft.EntityFrameworkCore;
using StationeryStore.DataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.BrandRepositoryContiner;
using StationeryStoreDataLayer.Repositories.EfRepositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.UnitOfWorks
{
    public class EfUnitOfWork : IDisposable
    {
        private DbContext dbContext = new StationeryStoreContext();
        private bool disposed;

        private IProductRepository _productsRepository;

        public IProductRepository ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _productsRepository = new ProductRepository(dbContext);
                }
                return _productsRepository;
            }
        }
        private IBrandRepository _brandRepository;

        public IBrandRepository BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new BrandRepository(dbContext);
                }
                return _brandRepository;
            }
        }



        public void Save()
        {
            dbContext.SaveChanges();
        }



        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                    dbContext?.Dispose();

                }



                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~EfUnitOfWork()
        {
            Dispose(false);
        }
    }
}
