using CadastroDeAlunos.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CadastroDeAlunos.Infra
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly CadastroDeAlunosContext Context;
        private DbSet<T> DbSet;
        private IQueryable<T> DefaultQuery { get; set; }

        public Repository(CadastroDeAlunosContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
            DefaultQuery = DbSet.AsQueryable<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Add Entity");
            }

            DbSet.Add(entity);
            Context.SaveChanges();
        }

        public void Add(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Add Entities");
            }

            DbSet.AddRange(entities);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Delete Entity");
            }

            DbSet.Remove(entity);
            Context.SaveChanges();
        }

        public void Delete(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Delete Entities");
            }

            DbSet.RemoveRange(entities);
            Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public IEnumerable<T> GetBy(Expression<Func<T, bool>> expression)
        {
            try
            {
                IQueryable<T> query = DefaultQuery.Where(expression);
                return query;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public T GetById(int id)
        {
            return DbSet.SingleOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Update Entity");
            }

            DbSet.Update(entity);
            Context.SaveChanges();
        }

        public void Update(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Update Entities");
            }

            DbSet.UpdateRange(entities);
            Context.SaveChanges();
        }
    }
}
