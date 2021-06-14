using Microsoft.AspNetCore.Mvc;
using Devecart.Models;
using System.Collections.Generic;

namespace Devecart.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1,name:"تاكسي تلفني",description:"تاكسي تلفني آنلاين",image:"project-1.jpg" ,client:"TAP30"),
                new Project(id:2,name:"زودفود",description:"سفارش آنلاين غذا",image:"project-2.jpg" , client:"ZoodFood"),
                new Project(id:3,name:"مدارس",description:"سيستم آنلاين آموزش مدارس",image:"project-3.jpg" , client:"MONOP"),
                new Project(id:4,name:"فضاپيما",description:"تحخقيقات فضانوردي",image:"project-4.jpg" , client:"NASA"),
                
            };

            return View(viewName: "_Projects", model: projects);
        }
    }
}
