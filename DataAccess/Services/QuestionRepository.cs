using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Data;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.InteropServices.ComTypes;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Lethal.Developer.DataAccess.Services
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public QuestionRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task CreateQuestionAsync(Question question)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                db.Questions.Add(question);

                await db.SaveChangesAsync();
            }
            catch (DbException dbex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Question>> GetQuestionsByTopicAsync(Guid userId, int topicId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                var questions = await db.Questions
                    .Include(t => t.Topic)
                    .Where(q => q.UserId == userId && q.TopicId == topicId).ToListAsync();

                return questions;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Question> GetQuestionByIdAsync(int questionId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                var question = await db.Questions.FirstOrDefaultAsync(q => q.Id == questionId);

                return question;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task DeleteQuestionAsync(int id)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var questionToRemove =  await db.Questions.FirstOrDefaultAsync(q => q.Id == id);

                db.Remove(questionToRemove);
                await db.SaveChangesAsync();
            }
            catch (DbException dbex)
            {

                throw;
            }
        }
    }
}
