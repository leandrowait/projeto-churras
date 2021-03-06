﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Application.Contracts
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        TEntity GetBayId(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void Dispose();
    }
}
