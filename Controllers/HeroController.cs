﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FantasySports.Models;
using FantasySports.DataAccess;

namespace FantasySports.Controllers
{
    public class HeroController : Controller
    {
        public ViewResult Hero()
        {
            return View(Models.Hero.createTestObject());
        }

        public ViewResult AvailableHeroes()
        {
            List<Models.Hero> allHeroes = HeroesData.getAllAvailableHeroes();
            return View(allHeroes);
        }
    }
}