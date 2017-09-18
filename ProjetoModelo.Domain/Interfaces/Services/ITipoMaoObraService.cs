using ProjetoModelo.Domain.Entities.Gestao;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface ITipoMaoObraService : IServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterMaoObraComPerformance(IEnumerable<TipoMaoObra> tiposMO);
    }
}
