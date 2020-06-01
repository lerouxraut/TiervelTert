using Core.Models;
using System.Collections.Generic;

namespace Logic.Repositories
{
    public interface IProductRepository
    {
        void Add(Product entity);
        IEnumerable<Product> All();
        Product Find(int id);
        IEnumerable<Product> FindByCategoryId(int breedId);
        void Remove(int id);
        void Remove(Product entity);
        void Update(Product entity);
    }
}