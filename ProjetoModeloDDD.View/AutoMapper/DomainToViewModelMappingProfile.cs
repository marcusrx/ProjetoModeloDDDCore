using AutoMapper;
using ProjetoModelo.Domain.Entities.Gestao;
using ProjetoModeloDDD.View.ViewModels;

namespace ProjetoModeloDDD.View.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public DomainToViewModelMappingProfile()
        {

            CreateMap<TipoMaoObra, TipoMaoObraViewModel>().ReverseMap();
            CreateMap<Disciplina, DisciplinaViewModel>().ReverseMap();
            CreateMap<Commodity, CommodityViewModel>().ReverseMap();
        }
    }
}
