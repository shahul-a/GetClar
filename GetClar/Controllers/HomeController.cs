using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetClar.Models;

namespace GetClar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(MemberLogin objMemberLogin)
        {

            return View();
        }

        [HttpGet]
        public ActionResult Account()
        {
            GetClarEntities objGetClarEntities = new GetClarEntities();

            ViewBag.Specialization = objGetClarEntities.Specializations.ToList();
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}