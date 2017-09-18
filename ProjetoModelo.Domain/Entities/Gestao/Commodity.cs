using ProjetoModelo.Domain.Core.Interfaces;

namespace ProjetoModelo.Domain.Entities.Gestao
{
    public class Commodity  : IModel<Commodity>
    {


        //Construtor vazio para o EF
        protected Commodity(){ }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoMaoObraID { get; set; }
        public int DisciplinaID { get; set; }

        public virtual TipoMaoObra TipoMaoDeObra { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}
