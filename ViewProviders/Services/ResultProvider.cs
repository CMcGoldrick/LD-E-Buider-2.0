using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Models;
using Lethal.Developer.ViewProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Services
{
    public class ResultProvider : IResultProvider
    {
        IResultRepository _resultRepository;

        public ResultProvider(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }

        public async Task AddResultAsync(float result, int topicId, Guid userId)
        {
            try
            {
                var resultModel = new Result
                {
                    UserId = userId,
                    Score = result,
                    TopicId = topicId,
                    CreatedDate = DateTime.UtcNow
                };

                await _resultRepository.AddResultAsync(resultModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
