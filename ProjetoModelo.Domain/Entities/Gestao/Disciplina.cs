using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Core.Interfaces;


namespace ProjetoModelo.Domain.Entities
{
    public class Disciplina : IModel<Disciplina>
    {
       
        //Construtor vazio para o EF
        protected Disciplina(){}

        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual IEnumerable<Commodity> Commodities { get; set; }
    }
}
