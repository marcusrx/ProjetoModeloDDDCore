using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModelo.Domain.Services
{
    public class TipoMaoObraService : ServiceBase<TipoMaoObra>, ITipoMaoObraService
    {
        private readonly ITipoMaoObraRepository _tipoMaoObraRespository;

        public TipoMaoObraService(ITipoMaoObraRepository tipoMaoObraRespository)
            : base(tipoMaoObraRespository)
        {
            _tipoMaoObraRespository = tipoMaoObraRespository;
        }

        public IEnumerable<TipoMaoObra> ObterMaoObraComPerformance(IEnumerable<TipoMaoObra> tiposMO)
        {
            return tiposMO.Where(tp => tp.TipoMObraComPerformance(tp));
        }
    }
}
