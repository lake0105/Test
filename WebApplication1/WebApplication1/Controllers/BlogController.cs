using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static WebApplication1.BlogDatebase;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            var db = new BlogDatebase();
            db.Database.CreateIfNotExists();
            var lst = db.BlogArticles.OrderBy(o => o.Id).ToList();
            ViewBag.BlogArticles = lst;
            return View();
        }

        public ActionResult AddArticle()
        {
            return View();
        }

        public ActionResult ArticleSave(string subject,string body)
        {
            var article = new BlogArticle();
            return View();
        }
    }
}