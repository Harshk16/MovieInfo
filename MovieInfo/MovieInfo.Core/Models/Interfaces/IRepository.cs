using System;
using System.Collections.Generic;

namespace MovieInfo.Core.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();

        T GetDetails(Guid Id);

        void Insert(T data);

        void Delete(T data);

        void Update(T data);

        void Save();
    }
}
