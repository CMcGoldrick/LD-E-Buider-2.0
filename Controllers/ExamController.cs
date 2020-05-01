using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.ViewProviders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lethal.Developer.Controllers
{
    public class ExamController : RootController
    {
        public ExamController(ITopicProvider topicProvider)
            :base(topicProvider)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}