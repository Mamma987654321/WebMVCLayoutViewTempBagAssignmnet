using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCLayoutViewTempBagAssignmnet.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "Customer Home Page";
            return View();
        }
        public ActionResult NameList()
        {
            List<string> coutomer = new List<string>()
        {
            "pra",
            "lilly",
            "vayu",
            "danial",
            "richa",
            "dipa"
        };
            ViewBag.nameList = coutomer;
            return View();

        }
    }

}