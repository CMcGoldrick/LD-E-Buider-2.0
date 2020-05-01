using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lethal.Developer.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            //UserFavoriteTeams = new HashSet<UserFavoriteTeam>();
        }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Result> Results { get; set; }
        public ICollection<Theory> Theory { get; set; }
    }
}
