using ProjetoModelo.Domain.Entities.Gestao;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class DisciplinaService : ServiceBase<Disciplina>, IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
            : base(disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }
    }
}
