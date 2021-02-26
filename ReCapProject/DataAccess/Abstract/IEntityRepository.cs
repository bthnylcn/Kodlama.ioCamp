﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filterin defaultu null
        T Get(Expression<Func<T, bool>> filter);//filter verilmeli defaultu null değil
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);//T ye ne tür verilirse o türde çalışacak.
    }
}
