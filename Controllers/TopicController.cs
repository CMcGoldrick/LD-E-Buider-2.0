using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.ViewProviders.Interfaces;
using Lethal.Developer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Lethal.Developer.Helpers.HttpResponseMessages;
using Lethal.Developer.ViewModels;

namespace Lethal.Developer.Controllers
{
    //[Authorize]
    public class TopicController : RootController
    {
        private readonly ITopicProvider _topicProvider;

        public TopicController(ITopicProvider topicProvider)
            : base(topicProvider)
        {
            _topicProvider = topicProvider;
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("topics/create")]
        public async Task<IActionResult> CreateTopic([FromBody] TopicViewModel topic)
        {
            try
            {
                await _topicProvider.CreateTopicAsync(UserId, topic);
                return Ok(Post.Success("question"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }


        //public ActionResult<Topic> Index()
        //{
        //    try
        //    {
        //        var userId = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B");

        //        var topic = _topicProvider.GetAllTopicsAsync(userId);
        //        return PartialView("_TopicsPartial", topic);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}


    }
}