using Domain.Contractss;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositorys
{
    public class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public BaseRepository()
        {
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
