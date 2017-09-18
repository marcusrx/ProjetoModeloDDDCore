using ProjetoModelo.Domain.Core.Interfaces;
using System;

namespace ProjetoModelo.Domain.Entities.Gestao
{
    public class Commodity  : IModel<Commodity>, IDisposable
    {


        //Construtor vazio para o EF
        protected Commodity(int id, string nome, string descricao, int tipoMaoObraID, int disciplinaID){
            ID = id;
            Nome = nome;
            Descricao = descricao;
            TipoMaoObraID = tipoMaoObraID;
            DisciplinaID = disciplinaID;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoMaoObraID { get; set; }
        public int DisciplinaID { get; set; }

        public virtual TipoMaoObra TipoMaoDeObra { get; set; }
        public virtual Disciplina Disciplina { get; set; }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
