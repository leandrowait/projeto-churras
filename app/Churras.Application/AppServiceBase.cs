using Churras.Application.Contracts;
using Churras.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Application
{
    public abstract class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        protected readonly IServiceBase<TEntity> service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            this.service = service;
        }

        public void Add(TEntity entity)
        {
            service.Add(entity);
        }

        public void Dispose()
        {
            service.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return service.GetAll();
        }

        public TEntity GetBayId(int id)
        {
            return service.GetBayId(id);
        }

        public void Remove(TEntity entity)
        {
            service.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            service.Update(entity);
        }
    }
}
