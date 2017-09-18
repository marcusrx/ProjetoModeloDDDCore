using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Core.Interfaces;
using System.Linq;
using ProjetoModelo.Domain.Entities.Recurso;

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

        private List<Funcionario> _funcionarios;
        public virtual IEnumerable<Funcionario> Funcionarios
        {
            get { return _funcionarios; }
        }
        

        public bool EquipeEmMobilizacao(Equipe equipe)
        {
            return equipe.Ativo && equipe.Mobilizacao;
        }



        public void AddFuncionario(Funcionario func)
        {
            if (Funcionarios.Where(f => f.ID == func.ID).Count() == 0)
                this._funcionarios.Add(func);
            else
                throw new Exception("O Funcionário já está na equipe");
        }
    }
}
