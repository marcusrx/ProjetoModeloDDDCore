using System;
using ProjetoModelo.Domain.Core.Interfaces;

namespace ProjetoModelo.Domain.Core.Models.Gestao
{
    public class CentroCusto : IModel<CentroCusto>, IDisposable
    {
        public int ID { get; set; }
        public string CodCentroCusto { get; set; }
        public DateTime PeriodoInicial { get; set; }
        public DateTime PeriodoFinal { get; set; }
        public bool OrdemCOntinua { get; set; }
        public bool Ativo { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
