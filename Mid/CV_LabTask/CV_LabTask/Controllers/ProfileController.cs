using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_LabTask.Controllers
{
    public class ProfileController : Controller
    {
        // GET: CV
        public ActionResult PersonalDetails()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
    }
}