using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendanceSystem.Models;

namespace AttendanceSystem.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            MyDatabase db = new MyDatabase();
            return View();
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
    }
}