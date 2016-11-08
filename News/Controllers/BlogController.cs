using System.Linq;
using System.Web.Mvc;
namespace News.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            var db = new BlogDatabase();
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