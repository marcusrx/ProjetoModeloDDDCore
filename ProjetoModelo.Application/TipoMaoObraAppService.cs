using ProjetoModelo.Application.Interface;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModelo.Application
{
    public class TipoMaoObraAppService : AppServiceBase<TipoMaoObra>, ITipoMaoObraAppService
    {
        private readonly ITipoMaoObraService _tipoMaoObraService;

        public TipoMaoObraAppService(ITipoMaoObraService tipoMaoObraService)
            : base(tipoMaoObraService)
        {
            _tipoMaoObraService = tipoMaoObraService;
        }

        public IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance()
        {
            return _tipoMaoObraService.ObterMaoObraComPerformance(_tipoMaoObraService.GetAll());
        }
    }
}
