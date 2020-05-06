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

        [HttpDelete]
        //[ValidateAntiForgeryToken]
        [Route("topics/delete/{id}")]
        public async Task<IActionResult> DeleteAction(int id)
        {
            try
            {
                await _topicProvider.DeleteTopicAsync(id);
                return Ok(Delete.Success("topic"));
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}