using PageListMVC.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PageListMVC;
namespace PageListMVC.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index(int? page)
        {
            int pageSize = 10; // Số sản phẩm (10) trên 1 trang
            int pageNumber = (page ?? 1); // Nếu ko đủ 10 sản phẩm thì tính 1 trang
            return View(db.Products.ToList().ToPagedList(pageNumber, pageSize));
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