using System;
using System.Collections.Generic;
using System.Text;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public  class EquipeFuncionarioService : ServiceBase<EquipeFuncionario>, IEquipeFuncionarioService
    {
        private readonly IEquipeFuncionarioRepository _equipeFuncionarioRepository;
        public EquipeFuncionarioService(IEquipeFuncionarioRepository equipeFuncionarioRepository)
            : base(equipeFuncionarioRepository)
        {
            _equipeFuncionarioRepository = equipeFuncionarioRepository;
        }
    }
}
