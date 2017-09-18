using ProjetoModelo.Domain.Entities.Gestao;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface ICommodityService : IServiceBase<Commodity>
    {
        IEnumerable<Commodity> BuscarPorNome(string nome);
        IEnumerable<Commodity> ObterCommoditiesComPerformance(IEnumerable<Commodity> commodities);
    }
}
