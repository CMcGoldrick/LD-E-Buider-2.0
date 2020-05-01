using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

// question and answer must be larg string type type 
//VARCHAR(MAX) if it's all going to be ascii-based, say for basic HTML tepmplates
//NVARCHAR(MAX) if the HTML could contain any content
namespace Lethal.Developer.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int TopicId { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Q { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string A { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; }
    }
}
