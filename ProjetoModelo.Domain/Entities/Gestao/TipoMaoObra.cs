

using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Core.Interfaces;

namespace ProjetoModelo.Domain.Entities.Gestao
{
    public class TipoMaoObra : IModel<TipoMaoObra> //: Entity
    {
        
        //Construtor vazio para o EF
        protected TipoMaoObra(){ }


        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Performance { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Commodity> Commodities { get; set; }


        public bool TipoMObraComPerformance(TipoMaoObra tipoMO)
        {
            return tipoMO.Ativo && tipoMO.Performance.Equals(true);
        }

        //public void AddCommodity(Commodity cmm)
        //{
        //    if (Commodities.Where(c => c.ID == cmm.ID).Count() == 0)
        //        this._commodities.Add(cmm);
        //    else
        //        throw new Exception("Esse tipo de Mão de Obra já possui a Commodity");
        //}
    }
}
