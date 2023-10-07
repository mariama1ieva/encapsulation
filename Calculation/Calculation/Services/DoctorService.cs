using Calculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Services
{
    internal class DoctorService
    {
        public Doctor[] GetAll()
        {
            Doctor dr1 = new()
            {
                Name = "Lena",
                SureName="Smith",
                Adress="London",
                Birthday=new(1992,06,04)
            };
            Doctor dr2 = new()
            {
                Name = "Nicol",
                SureName = "Green",
                Adress = "Los Angeles",
                Birthday = new(2000, 07, 02)
            };
            Doctor dr3 = new()
            {
                Name = "David",
                SureName = "King",
                Adress = "Paris",
                Birthday = new(2003, 08, 20)
            };
            Doctor dr4 = new()
            {
                Name = "Lucy",
                SureName = "White",
                Adress = "Italy",
                Birthday = new(1998, 01, 16)
            };
            Doctor[] doctors = new Doctor[] { dr1, dr2, dr3, dr4 };
            return doctors;
        }
        public Doctor[] ShowAllDoctors(DateTime Start, DateTime End)
        {
            Doctor[] doctors=GetAll();
            return doctors=doctors.Where(x=>x.Birthday> Start && x.Birthday<End).ToArray();
        }
    }
}
