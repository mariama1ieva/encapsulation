

using Calculations;
using Calculation.Services;
using Calculations.Models;
using Calculation.Controllers;
//CalculationService calc = new CalculationService();

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());


//Console.WriteLine(calc.SumOfNums(a, b));
//Console.WriteLine(calc.MinusOfNums(a, b));
//Console.WriteLine(calc.DivideOfNums(a, b));
//Console.WriteLine(calc.MultiplyOfNums(a, b));


//EmployeeControllers employeeController = new();
//employeeController.GetEmployee();


DoctorControllers doctorControllers = new DoctorControllers();
doctorControllers.GetAllDoctorsByBirthday();