﻿using System;
using System.Collections.Generic;

namespace LearnAngular.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        IEnumerable<TEntity> Find(Func<TEntity, bool> expr);
        TEntity Get(Func<TEntity, bool> expr);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
