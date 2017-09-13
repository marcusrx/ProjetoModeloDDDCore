using ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModelo.Application.Interface
{
    public interface ITipoMaoObraAppService : IAppServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance();
    }
}
