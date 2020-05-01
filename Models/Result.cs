using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Models
{
    public class Result
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int TopicId { get; set; }
        public float Score { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; }
    }
}
