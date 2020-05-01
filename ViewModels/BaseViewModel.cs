using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewModels
{
    public class BaseViewModel
    {
        public String PageTitle { get; set; }
        public String MetaKeywords { get; set; }
        public String MetaDescription { get; set; }
        
        public IEnumerable<TopicViewModel> Topics { get; set; }
    }
}
