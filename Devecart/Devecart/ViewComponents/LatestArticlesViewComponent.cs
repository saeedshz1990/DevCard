using Microsoft.AspNetCore.Mvc;
using Devecart.Models;
using System.Collections.Generic;

namespace Devecart.ViewComponents
{
    public class LatestArticlesViewComponent: ViewComponent
    {
public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(id:1,title:"Learn Asp.net core mvc",description:" Best Of seller",image:"blog-post-thumb-1.jpg"),
                new Article(id:2,title:"Learn Javascript",description:" Best Of JavaScript",image:"blog-post-thumb-2.jpg"),
                new Article(id:3,title:"Learn Asp.net core mvc",description:" Best Of seller",image:"blog-post-thumb-3.jpg"),

            };
            return View(viewName: "_LatestArticles",articles);
        }
    }
}
