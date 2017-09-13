using ProjetoModelo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface ITipoMaoObraService : IServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterMaoObraComPerformance(IEnumerable<TipoMaoObra> tiposMO);
    }
}
