﻿using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.DataAccess.Interfaces
{
    public interface ITopicRepository
    {
        Task CreateTopicAsync(Topic topic);
        Task<IEnumerable<Topic>> GetAllTopicsAsync(Guid userId);
        Task DeleteTopicAsync(int Id);
    }
}
