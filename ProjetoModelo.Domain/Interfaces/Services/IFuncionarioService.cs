using ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface IFuncionarioService : IServiceBase<Funcionario>
    {
        IEnumerable<Funcionario> GetByName(String name);
        IEnumerable<Funcionario> ObterFuncionariosSemEquipe(IEnumerable<Funcionario> funcs);
        IEnumerable<Funcionario> ObterFuncionariosEmMobilizacao(IEnumerable<Funcionario> funcs);
    }
}
