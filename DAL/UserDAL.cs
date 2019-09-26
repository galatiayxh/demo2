using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    /// <summary>
    /// UserDAL继承BaseDAL
    /// </summary>
    public class UserDAL : BaseDAL<Staff>
    {
        /// <summary>
        /// 在这里声明实例化一个UserDAL的对象
        /// </summary>
        public static readonly UserDAL GetUserDAL = new UserDAL();
        private UserDAL() { }
    }
}
