using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FantasySports.DataAccess;

namespace FantasySports.Controllers
{
    public class LeagueController : Controller
    {
        public ViewResult CreateLeague()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateLeague(String leagueName)
        {
            LeagueData.addLeague(leagueName);
            return Content("Form Submitted!");
        }
    }
}