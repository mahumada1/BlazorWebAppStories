using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesWebApp.Shared
{
    public class Story
    {
        public Story() => Visible = false;

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Category { get; set; }
        public bool Visible { get; set; }
        public string Text { get; set; }
        public int Id { get; set; }

    }
}
