using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSSJ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = UserBLL.GetUserBLL.GetModel(c => c.Id ==5 );
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}