using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL<T> where T : class, new()
    {
        //下面是两种写法获取EF上下文对象，
        private DbContext db = EFContextFactory.GetDbContextFromContext();
        protected DbContext DataContext
        {
            get { return EFContextFactory.GetDbContextFromContext(); }
        }


        /// <summary>
        /// 根据查询条件获取单个实体
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public T GetModel(Expression<Func<T, bool>> condition)
        {
            return DataContext.Set<T>().Where(condition).FirstOrDefault();
        }

        //public T GetModel<T>(Expression<Func<T, int>> condition) where T : class, new()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
