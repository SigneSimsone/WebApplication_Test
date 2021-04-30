using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Test.Data;
using WebApplication_Test.Models;

namespace WebApplication_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult Privacy()
        {
            PrivacyModel model = new PrivacyModel();
            model.User = "Admin";

            return View(model);
        }

        public IActionResult Contacts()
        {
            Contacts model = new Contacts();
            model.ContactsNames[0] = "Emma";
            model.ContactsNames[1] = "Drew";
            model.ContactsNames[2] = "Max";
            model.ContactsNames[3] = "Benj";
            model.ContactsNames[4] = "Felix";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
