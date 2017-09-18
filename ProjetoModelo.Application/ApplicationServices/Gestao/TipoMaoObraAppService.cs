using ProjetoModelo.Application.Interface.Gestao;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Entities.Gestao;
using ProjetoModelo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModelo.Application.ApplicationServices.Gestao
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
