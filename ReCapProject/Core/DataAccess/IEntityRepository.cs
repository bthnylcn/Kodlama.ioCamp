using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
//Core katmanı diğer katmanları ref almaz
namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);//filter verilmeli defaultu null değil
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);//T ye ne tür verilirse o türde çalışacak.
    }
}
