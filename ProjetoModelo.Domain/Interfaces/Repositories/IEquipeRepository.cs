using ProjetoModelo.Domain.Entities;

using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Repositories
{
    public interface IEquipeRepository : IRepositoryBase<Equipe>
    {
        IEnumerable<Equipe> GetByName(string name);
    }
}
