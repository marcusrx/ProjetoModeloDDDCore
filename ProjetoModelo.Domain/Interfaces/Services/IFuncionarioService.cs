using ProjetoModelo.Domain.Entities.Recurso;
using System;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface IFuncionarioService : IServiceBase<Funcionario>
    {
        IEnumerable<Funcionario> GetByName(String name);
        IEnumerable<Funcionario> ObterFuncionariosSemEquipe(IEnumerable<Funcionario> funcs);
        IEnumerable<Funcionario> ObterFuncionariosEmMobilizacao(IEnumerable<Funcionario> funcs);
    }
}
