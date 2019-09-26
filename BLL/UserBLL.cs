using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL : BaseBLL<Staff>
    {
        /// <summary>
        /// 在这里声明实例化一个UserBLL的对象
        /// </summary>
        public static readonly UserBLL GetUserBLL = new UserBLL();
        /// <summary>
        /// 要对BaseBLL中的抽象方法进行实现。
        /// </summary>
        public override void SetCurrentRepository()
        {
            CurrentRepository = UserDAL.GetUserDAL;//CurrentRepository属性在BaseBLL中定义
        }
    }
}
