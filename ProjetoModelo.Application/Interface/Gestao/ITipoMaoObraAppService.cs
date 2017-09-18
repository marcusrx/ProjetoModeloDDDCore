using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Entities.Gestao;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface.Gestao
{
    public interface ITipoMaoObraAppService : IAppServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance();
    }
}
