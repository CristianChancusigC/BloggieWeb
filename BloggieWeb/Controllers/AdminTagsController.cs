using BloggieWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BloggieWeb.Controllers
{
    public class AdminTagsController : Controller
    {
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
            var name = addTagRequest.Name;
            var displayname = addTagRequest.DisplayName;
            return View("Add");
        }
    }
}
