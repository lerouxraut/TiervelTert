using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Core.Models;

namespace Logic.Repositories
{
    internal class ProductRepository : RepositoryBase, IProductRepository
    {
        public ProductRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

        public IEnumerable<Product> All()
        {
            try
            {
                return Connection.Query<Product>("SELECT * FROM Product", null, transaction: Transaction).ToList<Product>();

            }
            catch (Exception e)
            {
                Console.WriteLine($"OMF: {e.Message}");
                throw;
            }
        }

        public Product Find(int id)
        {
            return Connection.Query<Product>(
                "SELECT * FROM Product WHERE ProductId = @ProductId",
                param: new { ProductId = id },
                transaction: Transaction
            ).FirstOrDefault();
        }

        public void Add(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entity.ProductId = Connection.ExecuteScalar<int>(
                "INSERT INTO Product([ProductNumber],[ProductDescription] ,[ModifiedBy],[ModifiedDate]) VALUES(@BreedId, @Name, @Age); SELECT SCOPE_IDENTITY()",
                param: new { ProductNumber = entity.ProductNumber, ProductDescription = entity.ProductDescription, ModifiedBy = 1, ModifiedDate = DateTime.Now },
                transaction: Transaction
            );
        }

        public void Update(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Connection.Execute(
                "UPDATE Product SET ProductName = @ProductName WHERE ProductId = @ProductId",
                param: new { ProductId = entity.ProductId, ProductNumber = entity.ProductNumber, Name = entity.ProductDescription },
                transaction: Transaction
            );
        }

        public void Remove(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.ProductId);
        }

        public void Remove(int id)
        {
            Connection.Execute(
                "DELETE FROM Product WHERE ProductId = @ProductId",
                param: new { ProductId = id },
                transaction: Transaction
            );
        }

        public IEnumerable<Product> FindByCategoryId(int categoryId)
        {
            return Connection.Query<Product>(
                "SELECT * FROM Product WHERE BreedId = @BreedId",
                param: new { CategoryId = categoryId },
                transaction: Transaction
            );
        }

    }
}
