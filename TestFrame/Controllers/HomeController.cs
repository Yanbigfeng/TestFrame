using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.IService;
using test.Data;

namespace TestFrame.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 属性注入
        /// </summary>
        /// <returns></returns>
         public IErrorLogService serviceError { get;  set; }

        public ILoginLogService serviceLogin { get; set; }
        public IBaseService serviceBase{ get; set; }


        public ActionResult Index()
        {
            try
            {

                //增加数据
                //serviceError.AddErrorLog();
                //serviceLogin.ModiyLoginLog();

                var data = serviceBase.Entities<SysLoginLogInfor>().ToList();
                var ss = data.FirstOrDefault();
                int nub = data.Count();

                //修改数据
                //serviceError.ModiyErrorLog("a7c042811d4848b2ad86f439b66abd06");
            }
            catch (Exception e)
            {

            }
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