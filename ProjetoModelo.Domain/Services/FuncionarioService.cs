using System.Collections.Generic;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;
using System.Linq;
using ProjetoModelo.Domain.Entities.Recurso;

namespace ProjetoModelo.Domain.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
            : base(funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public IEnumerable<Funcionario> GetByName(string name)
        {
            return _funcionarioRepository.GetByName(name);
        }

        public IEnumerable<Funcionario> ObterFuncionariosEmMobilizacao(IEnumerable<Funcionario> funcs)
        {
            return funcs.Where(f => f.Equipe.EquipeEmMobilizacao(f.Equipe));
        }

        public IEnumerable<Funcionario> ObterFuncionariosSemEquipe(IEnumerable<Funcionario> funcs)
        {
            return funcs.Where(f => f.Equipe == null);
        }
    }
}
