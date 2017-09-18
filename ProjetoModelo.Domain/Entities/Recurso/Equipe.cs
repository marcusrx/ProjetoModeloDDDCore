using System;
using System.Collections.Generic;
using System.Text;
using ProjetoModelo.Domain.Core.Interfaces;

namespace ProjetoModelo.Domain.Entities
{
    public class Equipe : IModel<Equipe>
    {
        public int ID { get; set; }
        public int CodColigada { get; set; }
        public int CodCentroCusto { get; set; }
        public string CentroCusto { get; set; }
        public int CodCelula { get; set; }
        //public Celula Celula { get; set; }
        public string DescEquipe { get; set; }
        public int CodSupervisor { get; set; }
        public bool Mobilizacao { get; set; }
        public bool Ativo { get; set; }
        public Funcionario SupervisorEquipe{ get; set; }
        public virtual IEnumerable<Funcionario> Funcionarios { get; set; }

        public bool EquipeEmMobilizacao(Equipe equipe)
        {
            return equipe.Ativo && equipe.Mobilizacao;
        }
    }
}
