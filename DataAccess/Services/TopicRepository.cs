using Lethal.Developer.Data;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Lethal.Developer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            catch (Exception dbex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Topic>> GetAllTopicsAsync(Guid userId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                var topic = await db.Topics.ToListAsync();

                return topic;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
