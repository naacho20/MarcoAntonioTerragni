﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarcoAntonioTerragniWeb.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Article()
        {
            return View();
        }
    }
}