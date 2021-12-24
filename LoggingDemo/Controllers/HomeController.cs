using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoggingDemo.Models;
using System.IO;

namespace LoggingDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("msg");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Add()
        {
            _logger.LogInformation("We are inside Add Method");
            return View();
        }
        [HttpPost]
        public ActionResult Add(string txtNo1, string txtNo2)
        {
            int div = 0;
            try
            {
                int no1 = int.Parse(txtNo1);
                int no2 = int.Parse(txtNo2);
                //if (no2 == 0)
                //{
                //    _logger.LogError("DO not pass 0 in txt2");
                //}
                 div = no1 / no2;
            }
            catch (Exception ex)

            {
                _logger.Log(LogLevel.Debug, "Debug");
                _logger.LogError(ex.Message.ToString());
                return View("Error", ex);
            }
            ViewBag.result = div;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index1(int? id)

        {
            if (id.HasValue)
            {
                if (id == 0)
                {

                    int x = 10;
                    int? res = x / id;
                    throw new DivideByZeroException();
                }
                
                if (id == 1)
                    throw new FileNotFoundException("File not found exception thrown in index.chtml");

                else if (id == 2)
                {
                    return StatusCode(500);
                }
            }
            return View();

        }

    }
}
