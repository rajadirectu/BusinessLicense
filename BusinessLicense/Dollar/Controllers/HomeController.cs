using Dollar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dollar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBusinessLicenseRepository _businessLicenseRepository;

        public HomeController(ILogger<HomeController> logger, IBusinessLicenseRepository businessLicenseRepository)
        {
            _logger = logger;
            _businessLicenseRepository = businessLicenseRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAllBusinessLicense(int? storeId)  
        {
            var businessLicenses = _businessLicenseRepository.GetAllBusinessLicense().ToList();
            if (storeId != null)
                businessLicenses = businessLicenses.Where(bl => bl.Store == storeId).ToList();
            return Json(new { data = businessLicenses });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
