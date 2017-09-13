using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjetoModelo.Domain.Entities;
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
        }
    }
}
