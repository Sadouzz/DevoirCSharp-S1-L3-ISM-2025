using Microsoft.AspNetCore.Mvc;
using Services;
using Models;
using Microsoft.EntityFrameworkCore;
using AspNetCoreGeneratedDocument;

namespace Controllers
{
    public class ApprovisionnementController : Controller
    {

        private readonly IApprovisionnementService _ApprovisionnementService;


        private readonly ILogger<ApprovisionnementController> _logger;

        public ApprovisionnementController(IApprovisionnementService ApprovisionnementService, ILogger<ApprovisionnementController> logger)
        {
            _ApprovisionnementService = ApprovisionnementService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {

            try
            {
                var Approvisionnements = _ApprovisionnementService.GetAllApprovisionnements();


                return View(Approvisionnements);
            }
            catch (Exception)
            {

                _logger.LogError("Erreur lors de l'affichage des approvisionnements.");
                return View(new List<Approvisionnement>());
            }


        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}