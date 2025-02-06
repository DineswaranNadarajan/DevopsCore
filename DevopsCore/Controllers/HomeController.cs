using DevopsCore.Models;
using DevopsCore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
namespace DevopsCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository postRepository;

        public HomeController()
        {
        }

        public HomeController(IPostRepository _postRepository)
        {
            this.postRepository = _postRepository;
        }

        public IActionResult Index()
        {
            var model = postRepository.GetPostData();
            return View(model);
        }
    }
}
