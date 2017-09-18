using System;
using ProjetoModelo.Domain.Core.Interfaces;

namespace ProjetoModelo.Domain.Core.Models
{
    public class Usuario : IModel<Usuario>,  IDisposable
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string GroupCode { get; set; }
        public string GroupType { get; set; }
        public string Description { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
