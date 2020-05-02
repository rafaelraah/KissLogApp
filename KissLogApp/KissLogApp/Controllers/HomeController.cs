using KissLog;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KissLogApp.Controllers
{
    public class HomeController : Controller
    {
        //ILogger, mesma nomenclatura de interface do log do asp.net
        private readonly KissLog.ILogger _logger;

        public HomeController(KissLog.ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ErrorSimulation()
        {
            _logger.Debug("Simulação de erro");
            return View();
        }

        public IActionResult ExceptionSimulation()
        {
            throw new Exception("Algo horrível aconteceu aqui!");
        }

        public double Calculo()
        {
            int number = 0; 
            return 5 / number;
        }

    }
}
