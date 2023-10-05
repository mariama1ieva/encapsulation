using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceencalsualtion.Models
{
    internal class Student:BaseEntity
    {
        public string name;
        public string surename;
        public string email;
        public DateTime birthday;
    }
}
