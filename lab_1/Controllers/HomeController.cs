using Microsoft.AspNetCore.Mvc;
using lab_1.Models;
using System;

namespace lab_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 101);
            var company = new Company
            {
                Name = "GuukPeef",
                Address = "123 Vashington Street, NewYork",
                RandomNumber = number
            };

            return Json(company);
        }

    }
}