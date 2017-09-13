using ProjetoModelo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface
{
    public interface ITipoMaoObraAppService : IAppServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance();
    }
}
