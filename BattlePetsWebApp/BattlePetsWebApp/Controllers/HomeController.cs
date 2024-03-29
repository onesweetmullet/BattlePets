﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BattlePetsWebApp.Models;

namespace BattlePetsWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult PetAttack()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PetAttack(PetAttackModel petAttackModel)
        {
            return View(petAttackModel);
        }
    }
}
