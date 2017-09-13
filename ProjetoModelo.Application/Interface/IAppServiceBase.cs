﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModelo.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetByID(int ID);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);

        void Dispose();
    }
}
