using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckTemp()
        {
           return View();
        }
        [HttpPost]
        public IActionResult CheckTemp(string name, float temp)
        {
            _ = new DoctorModel
            {
                Name = name,
                Temp = temp
            };

            ViewBag.Message = DoctorModel.Check(name, temp);
            return View();
        }
    }
}
