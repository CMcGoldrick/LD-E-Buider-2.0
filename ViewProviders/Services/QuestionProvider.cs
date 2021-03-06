﻿using Lethal.Developer.ViewModels;
using Lethal.Developer.ViewProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.DataAccess.Interfaces;
using System.Data.Common;

namespace Lethal.Developer.ViewProviders.Services
{
    public class QuestionProvider : IQuestionProvider
    {
        IQuestionRepository _questionRepository;
        ITopicRepository _topicRepository;

        public QuestionProvider(IQuestionRepository questionRepository, ITopicRepository topicRepository)
        {
            _questionRepository = questionRepository;
            _topicRepository = topicRepository;
        }

        public async Task CreateQuestionAsync(Guid userId, CreateQuestionViewModel question)
        {
            try
            {
                var questionModel = new Models.Question();

                questionModel.UserId = userId;
                questionModel.Q = question.Question;
                questionModel.A = question.Answer;
                questionModel.TopicId = question.TopicId;
                questionModel.CreatedDate = DateTime.UtcNow;

                await _questionRepository.CreateQuestionAsync(questionModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<QuestionViewModel> GetQuestionsByTopicAsync(Guid userId, int topicId, int? amount)
        {
            try
            {
                var questions = await _questionRepository.GetQuestionsByTopicAsync(userId, topicId, amount);
                var qs = new List<Question>();
                var qvm = new QuestionViewModel();

                foreach(var q in questions)
                {
                    qs.Add(new Question
                    { 
                        Id = q.Id,
                        Q = q.Q,
                        A = q.A
                    }); 
                }

                qvm.Questions = qs;
                qvm.TopicId = topicId;

                if (questions.Any())
                    qvm.TopicName = questions.FirstOrDefault().Topic.Name;
                else
                    qvm.TopicName = _topicRepository.GetTopicAsync(topicId).Result.Name;

                return qvm;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<QuestionViewModel> GetQuestionByIdAsync(int questionId)
        {
            try
            {
                var question = await _questionRepository.GetQuestionByIdAsync(questionId);
                var qvm = new QuestionViewModel();
                var ql = new List<Question>();

                ql.Add(new Question { Id = question.Id, Q = question.Q, A = question.A });

                qvm.TopicId = question.TopicId;
                qvm.Questions = ql;

                return qvm;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task UpdateQuestionAsync(CreateQuestionViewModel question)
        {
            try
            {
                await _questionRepository.UpdateQuestionAsync(question);
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
                await _questionRepository.DeleteQuestionAsync(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
