using ProjetoModelo.Domain.Entities.Recurso;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Repositories
{
    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        IEnumerable<Funcionario> GetByName(string name);
    }
}
