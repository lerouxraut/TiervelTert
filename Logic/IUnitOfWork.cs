using Logic.Repositories;
using System;

namespace Logic
{
    public interface IUnitOfWork : IDisposable
    {
        IBreedRepository BreedRepository { get; }
        IProductRepository ProductRepository { get; }

        void Commit();
    }
}
