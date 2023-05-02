using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int Writerid { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string Writerimage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPass { get; set; }




        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
