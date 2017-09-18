﻿using ProjetoModelo.Application.Interface;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModelo.Application
{
    public class CommodityAppService : AppServiceBase<Commodity>, ICommodityAppService
    {
        private readonly ICommodityService _commodityService;
        public CommodityAppService(ICommodityService commodityService)
            : base(commodityService)
        {
            _commodityService = commodityService;
        }
        public IEnumerable<Commodity> BuscarPorNome(string nome)
        {
            return _commodityService.BuscarPorNome(nome);
        }

        public IEnumerable<Commodity> ObterCommoditiesComPerformance()
        {
            return _commodityService.ObterCommoditiesComPerformance(_commodityService.GetAll());
        }

        //public IEnumerable<Commodity> GetCommodities()
        //{
        //    IEnumerable<Commodity> commodities = _commodityService.GetAll();
        //
        //    commodities.OrderBy(c => c.Disciplina = c)
        //
        //    return commodities;
        //}

    }
}
