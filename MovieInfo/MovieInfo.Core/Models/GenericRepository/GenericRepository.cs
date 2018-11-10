using MovieInfo.Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MovieInfo.Core.Models.GenericRepository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private Entities context;

        private IDbSet<T> dbEntity;

        public GenericRepository()
        {
            context = new Entities();
            dbEntity = context.Set<T>();
        }

        public void Delete(T data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            return dbEntity.ToList();
        }

        public T GetDetails(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T data)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T data)
        {
            throw new NotImplementedException();
        }
    }
}
