using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class ApprovisionnementController : Controller
    {
        public ApprovisionnementController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}