using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contractss
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(Guid Id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
    }
}
