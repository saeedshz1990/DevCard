using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Devecart.ViewComponents;
using Devecart.Controllers;
using Devecart.Models;

namespace Devecart.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project(long id, string name, string description,string image, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }

   
}
