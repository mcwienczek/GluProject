using GluWebsite.GluServiceProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GluWebsite.Controllers
{
    public class HomeController : Controller
    {
        private static IGluService _gluService;
        public static IGluService GluService
        {
            get
            {
                if (_gluService == null)
                    throw new ArgumentNullException("Web Service is null or unavailable");
                return _gluService;
            }
            set
            {
                _gluService = value;
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var result = GluService.GetData(10);
            ViewBag.WebServiceMessage = result;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}