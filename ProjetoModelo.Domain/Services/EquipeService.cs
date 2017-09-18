using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoModelo.Domain.Services
{
    public class EquipeService : ServiceBase<Equipe>, IEquipeService
    {
        private readonly IEquipeRepository _equipeRepository;
        public EquipeService(IEquipeRepository equipeRepository)
            : base(equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        public IEnumerable<Equipe> GetByName(string name)
        {
            return _equipeRepository.GetByName(name);
        }

        public IEnumerable<Equipe> ObterEquipesMobilizacao(IEnumerable<Equipe> equipes)
        {
            return equipes.Where(e => e.EquipeEmMobilizacao(e));
        }
    }
}
