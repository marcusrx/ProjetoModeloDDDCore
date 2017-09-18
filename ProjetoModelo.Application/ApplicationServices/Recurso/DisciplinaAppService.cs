using ProjetoModelo.Application.Interface.Recurso;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.ApplicationServices.Recurso
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
