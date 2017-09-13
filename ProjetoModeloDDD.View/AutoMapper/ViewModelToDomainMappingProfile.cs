using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjetoModeloDDD.View.ViewModels;
using ProjetoModelo.Domain.Entities;

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
            
        }
    }
}
