using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Interfaces
{
    public interface IResultProvider
    {
        Task AddResultAsync(float score, int topicId, Guid userId);
    }
}
