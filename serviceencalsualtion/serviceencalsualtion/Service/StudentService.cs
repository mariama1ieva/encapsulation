using serviceencalsualtion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace serviceencalsualtion.Service
{
    internal class StudentService
    {
        private Student[] GetAll()
        {
            Student stu1 = new()
            {
                name = "Meryem",
                surename = "aliyeva",
                email = "meryem@gmail.com",
                Id = 1,
                birthday = new(2002,07,30) 
            };
            Student stu2 = new()
            {
                name = "arzu",
                surename = "quluyeva",
                email = "arzu@gmail.com",
                Id = 2,
                birthday = new(1995,06,25)
            };
            Student stu3 = new()
            {
                name = "haci",
                surename = "ahmedov",
                email = "haci@gmail.com",
                Id = 3,
                birthday = new(1990,04,20)

            };
            Student stu4 = new()
            {
                name = "tofiq",
                surename = "nesibli",
                email = "nesibli@gmail.com",
                Id = 4,
                birthday = new(2000,02,20)
            };

            return new Student[] { stu1, stu2, stu3, stu4 };
        }
        public Student[] ShowAllStudents(DateTime start,DateTime end)
        {
            Student[] students = GetAll();
            var result = students.Where(x => x.birthday > start && x.birthday < end).ToArray();
            return result;
        }

        public int GetNameById(int Id)
        {
            Student[] students= GetAll();
            Student student= students.FirstOrDefault(x => x.Id == Id);

            int result = DateTime.Now.Year - student.birthday.Year;
            return result;
        }
        
    }

}
