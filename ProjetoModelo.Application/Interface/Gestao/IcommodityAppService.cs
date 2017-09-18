using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Entities.Gestao;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface.Gestao
{
    public interface ICommodityAppService : IAppServiceBase<Commodity>
    {
        IEnumerable<Commodity> BuscarPorNome(string nome);
        IEnumerable<Commodity> ObterCommoditiesComPerformance();
    }
}
