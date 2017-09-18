using AutoMapper;
using ProjetoModelo.Domain.Entities.Gestao;
using ProjetoModeloDDD.View.ViewModels;

namespace ProjetoModeloDDD.View.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TipoMaoObraViewModel, TipoMaoObra>().ReverseMap();
            CreateMap<DisciplinaViewModel, Disciplina>().ReverseMap();
            CreateMap<CommodityViewModel, Commodity>().ReverseMap();

        }
    }
}
