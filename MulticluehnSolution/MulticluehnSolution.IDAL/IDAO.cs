using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MulticluehnSolution.IDAL
{
    public interface IDAO
    {
        T Update<T>(T entity) where T : class;
        T Insert<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        T Find<T>(params object[] keyValues) where T : class;
        List<T> FindAll<T>(Expression<Func<T, bool>> conditions = null) where T : class;
      //  PagedList<T> FindAllByPage<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) where T : class;
    }
}
