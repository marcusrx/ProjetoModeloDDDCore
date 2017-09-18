using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Core.Interfaces;


namespace ProjetoModelo.Domain.Entities.Gestao
{
    public class Disciplina : IModel<Disciplina>
    {
       
        //Construtor vazio para o EF
        protected Disciplina(int disciplinaID, string nome, bool ativo, DateTime dataCadastro){
            DisciplinaID = disciplinaID;
            Nome = nome;
            Ativo = ativo;
            DataCadastro = dataCadastro;
        }

        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual IEnumerable<Commodity> Commodities { get; set; }
    }
}
