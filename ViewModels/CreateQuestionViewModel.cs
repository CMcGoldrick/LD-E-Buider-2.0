using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewModels
{
    public class CreateQuestionViewModel
    {
        public int TopicId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
