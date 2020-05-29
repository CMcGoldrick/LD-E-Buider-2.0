using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Lethal.Developer.Data;

namespace Lethal.Developer.DataAccess.Services
{
    public class ResultRepository : IResultRepository
    {
        IServiceProvider _serviceProvider;

        public ResultRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task AddResultAsync(Result result)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                db.Add(result);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
