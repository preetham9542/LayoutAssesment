using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAssesment.Controllers
{
    public class AssessmentController : Controller
    {
        // GET: Assessment
        public ActionResult Index()
        {
            List<String> Names = new List<String>
            {
                "Preetham",
                "Praneeth",
                "Sreenidhi"
            };
            ViewBag.msg = " Welcome! Here are our valued customers:";
            ViewBag.CNames = Names;
            return View();
        }
        public ActionResult RedirectDemo()
        {
            TempData["message"] = "Welcome";
            return RedirectToAction("DisplayMessage");
        }
        public ActionResult DisplayMessage()
        {
            var message = TempData["message"] as string;
            ViewBag.message1 = message;
            TempData.Clear();
            return View();
        }





    }
}