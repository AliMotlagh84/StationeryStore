using Microsoft.EntityFrameworkCore;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.BrandRepositoryContiner;
using StationeryStoreDataLayer.Repositories.EfRepositories.ProductRepository;
using StationeryStoreDataLayer.Repositories.EfRepositories.ProductRepositoryContainer;
using StationeryStoreDataLayer.Repositories.EfRepositories.UserRepositoryContainer;
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


        private IUserRepository _userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(dbContext);
                }
                return _userRepository;
            }
        }


        private IAdressRepository _adressRepository;

        public IAdressRepository AdressRepository
        {
            get
            {
                if (_adressRepository == null)
                {
                    _adressRepository = new AdressRepository(dbContext);
                }
                return _adressRepository;
            }
        }

        private IOrderRepository _orderRepository;

        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(dbContext);
                }
                return _orderRepository;
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
