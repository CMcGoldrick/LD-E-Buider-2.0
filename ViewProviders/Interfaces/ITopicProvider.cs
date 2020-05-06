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
        Task<IEnumerable<TopicViewModel>> GetAllTopicsAsync(Guid userId);
        Task DeleteTopicAsync(int id);
    }
}
