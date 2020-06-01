using Logic.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using Core.Models;

namespace Logic
{
        public class UnitOfWork : IUnitOfWork
        {
            private IDbConnection _connection;
            private IDbTransaction _transaction;
            private IBreedRepository _breedRepository;
            private IProductRepository _productRepository;
            private bool _disposed;

            public UnitOfWork(string connectionString)
            {
                _connection = new SqlConnection("Server=DESKTOP-3BNONGH\\SQL2019;Initial Catalog=TierData;MultipleActiveResultSets=true;User ID=sa;Password=nixdorf6");
                _connection.Open();
                _transaction = _connection.BeginTransaction();
            }

            public IBreedRepository BreedRepository
            {
                get { return _breedRepository ?? (_breedRepository = new BreedRepository(_transaction)); }
            }

            public IProductRepository ProductRepository
        {
                get { return _productRepository ?? (_productRepository = new ProductRepository(_transaction)); }
            }

            public void Commit()
            {
                try
                {
                    _transaction.Commit();
                }
                catch
                {
                    _transaction.Rollback();
                    throw;
                }
                finally
                {
                    _transaction.Dispose();
                    _transaction = _connection.BeginTransaction();
                    resetRepositories();
                }
            }

            private void resetRepositories()
            {
                _breedRepository = null;
                _productRepository = null;
            }

            public void Dispose()
            {
                dispose(true);
                GC.SuppressFinalize(this);
            }

            private void dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        if (_transaction != null)
                        {
                            _transaction.Dispose();
                            _transaction = null;
                        }
                        if (_connection != null)
                        {
                            _connection.Dispose();
                            _connection = null;
                        }
                    }
                    _disposed = true;
                }
            }

            ~UnitOfWork()
            {
                dispose(false);
            }
        }
}
