using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Devecart.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
