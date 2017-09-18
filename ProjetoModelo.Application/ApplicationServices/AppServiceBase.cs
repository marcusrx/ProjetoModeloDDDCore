﻿using ProjetoModelo.Application.Interface;
using ProjetoModelo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModelo.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetByID(int ID)
        {
            return _serviceBase.GetByID(ID);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
