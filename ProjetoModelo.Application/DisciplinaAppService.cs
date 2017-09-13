using ProjetoModelo.Application.Interface;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application
{
    public class DisciplinaAppService : AppServiceBase<Disciplina>, IDisciplinaAppService
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaAppService(IDisciplinaService disciplinaService)
            : base(disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }
    }
}
