using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.DataAccess.Interfaces
{
    public interface IQuestionRepository
    {
        Task CreateQuestionAsync(Question question);
        Task<IEnumerable<Question>> GetQuestionsByTopicAsync(Guid userId, int topicId);
        Task<Question> GetQuestionByIdAsync(int questionId);
        Task DeleteQuestionAsync(int Id);
    }
}
