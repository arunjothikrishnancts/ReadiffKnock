﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadifyKnock.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            ViewBag.Title = "Home Page";

            return "Welcome to Readify";
        }
    }
}
