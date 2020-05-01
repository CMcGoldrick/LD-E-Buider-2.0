using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewModels
{
    public class QuestionViewModel : BaseViewModel
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }

    public class Question
    {
        public string Q { get; set; }
        public string A { get; set; }
    }
}
