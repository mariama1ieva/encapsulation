using Calculation.Models;
using Calculation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Controllers
{
    internal class DoctorControllers
    {
        public void GetAllDoctorsByBirthday()
        {
            DateTime  Start = new(25, 05, 1993);
            DateTime End = new(15, 12, 2002);
            DoctorService doctorServices = new DoctorService();
            Doctor[] doctors = doctorServices.ShowAllDoctors(Start, End);
            foreach(var item in doctors)
            {
                Console.WriteLine(item.Name,item.SureName,item.Adress);
            }
            GetAllDoctorsByBirthday();
        }
    }
}
