using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
using MulticluehnSolution.IDAL;

namespace MulticluehnSolution.DAL
{
    public class DaoBase:IDisposable,IDAO
    {
        public DbContext context;

        public DaoBase()
        {
            this.context = new MulticluehnSolution.DAL.DbContext();
        }

        public T Update<T>(T entity) where T : class
        {
            var set = context.Set<T>();
            set.Attach(entity);
            context.Entry<T>(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity;
        }

        public T Insert<T>(T entity) where T : class
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Entry<T>(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T Find<T>(params object[] keyValues) where T : class
        {
            return context.Set<T>().Find(keyValues);
        }

        public List<T> FindAll<T>(Expression<Func<T, bool>> conditions = null) where T : class
        {
            if (conditions == null)
                return context.Set<T>().ToList();
            else
                return context.Set<T>().Where(conditions).ToList();
        }

        //public PagedList<T> FindAllByPage<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) where T : class
        //{
        //    var queryList = conditions == null ? context.Set<T>() : context.Set<T>().Where(conditions) as IQueryable<T>;

        //    return queryList.OrderByDescending(orderBy).ToPagedList(pageIndex, pageSize);
        //}

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
