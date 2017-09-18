using ProjetoModelo.Domain.Core.Interfaces;

namespace ProjetoModelo.Domain.Entities
{
    public class Funcionario : IModel<Funcionario>
    {
        public int ID { get; set; }
        public int CodColigada { get; set; }
        public int CodCentroCusto { get; set; }
        public string CentroCusto { get; set; }
        public string Nome{ get; set; }
        public bool Ativo { get; set; }
        public virtual Equipe Equipe { get; set; }

    }
}
