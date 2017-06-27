using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChild.Data.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public string SubHeader { get; set; }
    }
}
