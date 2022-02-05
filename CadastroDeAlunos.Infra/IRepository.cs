using CadastroDeAlunos.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CadastroDeAlunos.Infra
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetBy(Expression<Func<T, bool>> expression);
        T GetById(int id);
        void SaveChanges();
        void Update(T entity);
        void Update(IEnumerable<T> entities);
    }
}
