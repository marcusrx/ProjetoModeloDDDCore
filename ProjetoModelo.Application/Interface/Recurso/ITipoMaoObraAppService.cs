using ProjetoModelo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface.Recurso
{
    public interface ITipoMaoObraAppService : IAppServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance();
    }
}
