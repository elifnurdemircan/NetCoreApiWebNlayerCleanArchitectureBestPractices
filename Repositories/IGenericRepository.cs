﻿using System.Linq.Expressions;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace App.Repositories
{
    public interface IGenericRepository<T, TId> where T : class where TId : struct
    {
        public Task<bool> AnyAsync(TId id);
        IQueryable<T> GetAll();

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        ValueTask<T?> GetByIdAsync(int id);
        ValueTask AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
