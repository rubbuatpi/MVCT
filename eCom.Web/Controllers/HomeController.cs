using eCom.DAL.Data;
using eCom.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCom.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //DataContext _context = new DataContext();
            CustomerRepository _customer = new CustomerRepository(new DataContext());
            
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