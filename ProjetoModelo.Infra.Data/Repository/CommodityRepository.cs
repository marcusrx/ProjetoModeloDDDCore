using Microsoft.EntityFrameworkCore;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModelo.Infra.Data.Repository
{
    public class CommodityRepository : RepositoryBase<Commodity>, ICommodityRepository
    {
        public IEnumerable<Commodity> GetByName(string name)
        {
            return Db.Commodities.Where(c => c.Nome.Equals(name));
        }
        
        /// <summary>
        /// Aparentemente o Lazy Loading nao está funcionando no EF Core 2.0
        /// Método sobrescrito por esse motivo
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Commodity> GetAll()
        {
            return Db.Commodities.Include(c => c.Disciplina).Include(c => c.TipoMaoDeObra);
        }
    }
}
