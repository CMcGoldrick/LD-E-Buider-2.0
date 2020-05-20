using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewModels
{
    public class ExamViewModel : BaseViewModel
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
