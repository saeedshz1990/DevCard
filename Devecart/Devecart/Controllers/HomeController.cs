using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Devecart.Models;
using RestSharp;
using Microsoft.AspNetCore.Http;
using System;

namespace Devecart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    return Json(Ok());
        //}


            [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(data: Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
