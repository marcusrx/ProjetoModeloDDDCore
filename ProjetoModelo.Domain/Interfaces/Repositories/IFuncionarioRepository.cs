﻿using ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModelo.Domain.Interfaces.Repositories
{
    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        IEnumerable<Funcionario> GetByName(string name);
    }
}