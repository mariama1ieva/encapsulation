using serviceencalsualtion.Models;
using serviceencalsualtion.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceencalsualtion.Controllers
{
    internal class StudentController
    {
        public void GetAllFilteredStudents()
        {
            DateTime start = new(1999, 02, 04);
            DateTime end = new(2004, 05, 20);
            StudentService studentService = new StudentService();
            Student[] students = studentService.ShowAllStudents(start, end);
            foreach (var student in students)
            {
                var result = $"{student.name},{student.birthday}";
                Console.WriteLine(result);
            }
        }
        public void StudentAge()
        {
            StudentService studentService = new StudentService();
            Console.WriteLine(studentService.GetNameById(3));
        }

    }
}
