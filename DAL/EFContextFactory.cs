using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    class EFContextFactory
    {
        #region 从线程的数据槽中获得上下文对象
        /// <summary>
        /// 从线程的数据槽中获得上下文对象
        /// </summary>
        /// <returns></returns>
        public static DbContext GetDbContextFromContext()
        {
            DbContext context = CallContext.GetData("Dbcontext") as CompanyEntities;
            if (context == null)
            {
                context = new CompanyEntities();
                CallContext.SetData("Dbcontext", context);
            }
            return context;
        }
        #endregion
    }
}
