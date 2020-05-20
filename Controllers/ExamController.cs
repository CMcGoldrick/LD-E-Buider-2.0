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
        IQuestionProvider _questionProvider;
        ITopicProvider _topicProvider;

        public ExamController(ITopicProvider topicProvider, IQuestionProvider questionProvider)
            :base(topicProvider)
        {
            _questionProvider = questionProvider;
            _topicProvider = topicProvider;
        }

        [HttpGet]
        [Route("exam/{topicId}")]
        public async Task<IActionResult> ExamTopic(int topicId)
        {
            var topic = await _topicProvider.GetTopicsAsync(UserId, topicId);
            var bvm = await BaseViewModel;
            topic.FirstOrDefault().Topics = bvm.Topics;

            return View(topic.FirstOrDefault());
        }
    }
}