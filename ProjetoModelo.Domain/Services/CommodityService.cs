using ProjetoModelo.Domain.Entities.Gestao;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModelo.Domain.Services
{
    public class CommodityService : ServiceBase<Commodity>, ICommodityService
    {
        private readonly ICommodityRepository _commodityRepository;

        public CommodityService(ICommodityRepository commodityRepository)
            : base(commodityRepository)
        {
            _commodityRepository = commodityRepository;
        }

        public IEnumerable<Commodity> BuscarPorNome(string nome)
        {
            return _commodityRepository.GetByName(nome);
        }

        public IEnumerable<Commodity> ObterCommoditiesComPerformance(IEnumerable<Commodity> commodities)
        {
            return commodities.Where(c => c.TipoMaoDeObra.TipoMObraComPerformance(c.TipoMaoDeObra));
        }
    }
}
