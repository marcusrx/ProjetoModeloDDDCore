using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);

        TEntity GetByID(int ID);
        IEnumerable<TEntity> GetAll();

        void Dispose();
    }
}
