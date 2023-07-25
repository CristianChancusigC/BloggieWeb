using BloggieWeb.Data;
using BloggieWeb.Models.Domain;
using BloggieWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BloggieWeb.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BloggieDbContext bloggieDbContext;

        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //var name = Request.Form["name"];
            //var displayname = addTagRequest.DisplayName;
            // Mapping AddTsgReques to Tag Domian model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };
            bloggieDbContext.Tags.Add(tag);
            bloggieDbContext.SaveChanges();
            return View("Add");
        }
    }
}
