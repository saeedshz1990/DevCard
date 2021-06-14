using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Devecart.ViewComponents;
using Devecart.Controllers;
using Devecart.Models;

namespace Devecart.Models
{
    public class IndexModel
    {
        public List<Project> Projects { get; set; }
        public List<Article> Articles { get; set; }

    }
}
