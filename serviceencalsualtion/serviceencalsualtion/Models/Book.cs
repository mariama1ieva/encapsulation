using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceencalsualtion.Models
{
    internal class Book:BaseEntity
    {
        public int pagecount { get; set; }
        public string name { get; set; }
        public string author { get; set; }


    }
}
