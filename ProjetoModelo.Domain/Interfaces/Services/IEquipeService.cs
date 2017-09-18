using ProjetoModelo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface IEquipeService : IServiceBase<Equipe>
    {
        IEnumerable<Equipe> GetByName(string name);
        IEnumerable<Equipe> ObterEquipesMobilizacao(IEnumerable<Equipe> equipes);
    }
}
