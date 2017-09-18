using ProjetoModelo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface.Recurso
{
    public interface ICommodityAppService : IAppServiceBase<Commodity>
    {
        IEnumerable<Commodity> BuscarPorNome(string nome);
        IEnumerable<Commodity> ObterCommoditiesComPerformance();
    }
}
