using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Models;
using Lethal.Developer.ViewModels;
using Lethal.Developer.ViewProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Services
{
    public class TopicProvider : ITopicProvider
    {
		private readonly ITopicRepository _topicRepository;

		public TopicProvider(ITopicRepository topicRepository)
		{
			_topicRepository = topicRepository;
		}

		public async Task CreateTopicAsync(Guid userId, TopicViewModel tvm)
		{
			try
			{
				var topic = new Topic();

				topic.CreatedDate = DateTime.UtcNow;
				topic.Name = tvm.Name;
				topic.UserId = userId;

				await _topicRepository.CreateTopicAsync(topic);
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public async Task <IEnumerable<TopicViewModel>> GetAllTopicsAsync(Guid userId)
        {
			try
			{
				var topics = await _topicRepository.GetAllTopicsAsync(userId);
				var tvm = new List<TopicViewModel>();
				
				foreach(var t in topics)
				{
					tvm.Add(new TopicViewModel { Id = t.Id, Name = t.Name});
				}

				return tvm;
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
