 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult List()
        {
            string[] data = new string[] { "这些作品影响习近平数十年", "习近平同乌拉圭总统会谈 建立中乌战略伙伴关系", "李克强：奋力开创东北全面振兴新局面", "三季度GDP增6.7%与前值持平 房地产销售起到重要作用" };
            ViewBag.data = data;
            ViewData["data"]= data;
            ViewData.Model = data;
            return View();
        }
    }
}