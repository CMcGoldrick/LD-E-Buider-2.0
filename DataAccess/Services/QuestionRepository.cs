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

        public async Task<IEnumerable<Question>> GetQuestionsByTopicAsync(Guid userId, int topicId, int? amount)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var questions = new List<Question>();

                if(amount == default)
                {
                    questions = await db.Questions
                        .Include(t => t.Topic)
                        .Where(q => q.UserId == userId && q.TopicId == topicId).ToListAsync();
                }
                else
                {
                    var random = new Random();

                    questions = await db.Questions
                        .Include(t => t.Topic)
                        .Where(q => q.UserId == userId && q.TopicId == topicId).
                        ToListAsync();

                    questions = questions.OrderBy(x => random.Next()).Take((int)amount).ToList();
                }

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

        public async Task UpdateQuestionAsync(ViewModels.CreateQuestionViewModel q)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                var question = await db.Questions.FirstOrDefaultAsync(q => q.Id == q.Id);

                question.Q = q.Question;
                db.Entry(question).Property("Q").IsModified = true;

                question.A = q.Answer;
                db.Entry(question).Property("A").IsModified = true;

                var rowsUpdated = await db.SaveChangesAsync();

                if (rowsUpdated == 0)
                    throw new DbUpdateException("Unable to update DB");
            }
            catch (DbUpdateException dbex)
            {
                //_logger.LogError($"ERROR - This Watchlist item can not be updated-> {dbex.Message} {dbex.StackTrace}");
                throw new DbUpdateException("Unable to update question");
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
