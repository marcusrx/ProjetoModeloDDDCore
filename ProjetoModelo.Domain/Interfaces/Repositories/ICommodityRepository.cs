using ProjetoModelo.Domain.Entities.Gestao;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Repositories
{
    public interface ICommodityRepository : IRepositoryBase<Commodity>
    {
        IEnumerable<Commodity> GetByName(string name);
    }
}
