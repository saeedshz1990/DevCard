using Microsoft.AspNetCore.Mvc;
using Devecart.Models;
using System.Collections.Generic;
using Devecart.Data;

namespace Devecart.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var projects = ProjectsStore.GetProjects();
            return View(viewName: "_Projects", model: projects);
        }
    }
}
