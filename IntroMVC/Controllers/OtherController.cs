﻿using Microsoft.AspNetCore.Mvc;
using IntroMVC.Models;

namespace IntroMVC.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/stuff/{year:min(2020)}/{month:range(1,12)}/{key}")]
        public IActionResult Details(int year, int month, string key)
        {
            ViewBag.year = year;
            ViewBag.month = month;
            ViewBag.key = key;
            return View();
        }
        public IActionResult PageOne()
        {
            Person person = new Person {
                Id = 1,
                FirstName = "Tim",
                LastName = "Mwangi",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddDays(-7500))
            };

            return View(person);
        }
    }
}
