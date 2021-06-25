using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Devecart.Models;
using RestSharp;
using Microsoft.AspNetCore.Http;
using System;
using Devecart.Data;

namespace Devecart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult ProjectDetails(long id)
        {
            var project = ProjectsStore.GetProjectBy(id);
            return View(project);
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
        public IActionResult Contact(Contact model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده اشتباه می باشد لطفا دوباره تلاش کنید......";
                return View(model);
            }
            ViewBag.success = "نظر شما با موفقیت ارسال شد.باتشکر";
            return View();
            //return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
