﻿using Microsoft.AspNetCore.Mvc;

namespace EventoPwa.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
