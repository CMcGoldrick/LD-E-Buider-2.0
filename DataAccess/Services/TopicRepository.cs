using Lethal.Developer.Data;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Lethal.Developer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Lethal.Developer.DataAccess.Services
{
    public class TopicRepository : ITopicRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public TopicRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task CreateTopicAsync(Topic topic)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                db.Add(topic);
                await db.SaveChangesAsync();
            }
            catch (DbException)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Topic>> GetTopicsAsync(Guid userId, int? topicId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var topics = new List<Topic>();

                if (topicId == default)
                    topics = await db.Topics.ToListAsync();
                else
                    topics = await db.Topics.Where(t => t.Id == topicId).ToListAsync();

                return topics;
            }
            catch (DbException)
            {

                throw;
            }
        }

        public async Task<Topic> GetTopicAsync(int id)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                var topic = await db.Topics.FirstOrDefaultAsync(t => t.Id == id);

                return topic;
            }
            catch (DbException)
            {

                throw;
            }

        }

        public async Task DeleteTopicAsync(int id)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var topic = await db.Topics.FirstOrDefaultAsync(t => t.Id == id);

                db.Remove(topic);
                await db.SaveChangesAsync();
            }
            catch (DbException)
            {

                throw;
            }
        }
    }
}
