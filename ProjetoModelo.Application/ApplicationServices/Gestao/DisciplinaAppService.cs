using ProjetoModelo.Application.Interface.Gestao;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Entities.Gestao;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.ApplicationServices.Gestao
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
