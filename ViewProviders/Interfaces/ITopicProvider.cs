using Lethal.Developer.Models;
using Lethal.Developer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Interfaces
{
    public interface ITopicProvider
    {
        Task CreateTopicAsync(Guid userId, TopicViewModel topic);
        Task<IEnumerable<TopicViewModel>> GetTopicsAsync(Guid userId, int? topicId);
        Task DeleteTopicAsync(int id);
    }
}
