using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdAvaloniaApp.Models
{
    public class Notes
    {
        public string Title { get; set; }
        public string Article { get; set; }
        public string Tags { get; set; }
        public Notes(string title, string tag, string article)
        {
            Title = title;
            Article = article;
            Tags = tag;
        }
    }
}
