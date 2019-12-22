using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinesApiProj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FineRulesAjax()
        {
            return View();
        }
        public ActionResult StudentFinesAjax()
        {
            return View();
        }
    }
}