using Lethal.Developer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Interfaces
{
    public interface IQuestionProvider
    {
        Task CreateQuestionAsync(Guid userId, CreateQuestionViewModel question);
        Task<QuestionViewModel> GetQuestionsByTopicAsync(Guid userId, int topicId);
    }
}
