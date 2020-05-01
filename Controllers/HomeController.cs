using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lethal.Developer.Models;
using Lethal.Developer.ViewModels;
using Lethal.Developer.ViewProviders.Interfaces;

namespace Lethal.Developer.Controllers
{
    public class HomeController : RootController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITopicProvider topicProvider)
            :base(topicProvider)
        {
            _logger = logger;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Index()
        {
            var hvm = new HomeViewModel();
            var bvm = await BaseViewModel;
            hvm.Topics = bvm.Topics;

            return View(hvm);
        }

        public IActionResult GetHome()
        {
            return View(new HomeViewModel());
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
