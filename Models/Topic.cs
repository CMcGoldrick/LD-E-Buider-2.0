using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Theory> Theory { get; set; }
    }
}
