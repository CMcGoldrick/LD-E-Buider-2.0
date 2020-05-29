using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.Helpers.HttpResponseMessages;
using Lethal.Developer.Models;
using Lethal.Developer.ViewProviders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lethal.Developer.Controllers
{
    public class ResultController : RootController
    {
        IResultProvider _resultProvider;

        public ResultController(ITopicProvider topicProvider, IResultProvider resultProvider)
            : base(topicProvider)
        {
            _resultProvider = resultProvider; 
        }

        [HttpPost]
        [Route("result/create/{score}/{topicId}")]
        public async Task<IActionResult> Index(float score, int topicId)
        {
            try
            {
                await _resultProvider.AddResultAsync(score, topicId, UserId);
                return Ok(Post.Success("result"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("results/{topicId}")]
        public async Task<IActionResult> ResultsByTopic(int topicId)
        {
            var bvm = await BaseViewModel;

            return View(bvm);
        }

    }
}
