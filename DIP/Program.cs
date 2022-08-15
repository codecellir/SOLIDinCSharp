


using DIP.WithoutSOLID;
using DIP.WithSOLID;

//Employee employee = new Employee();
//employee.Name = "CodeCell";
//employee.HourseWorked = 8;
//employee.HourlyRate = 40_000;

//Console.WriteLine(employee.GetSalary());


EmployeeWithSOLID employeeWithSOLID = new EmployeeWithSOLID(new SalaryCalculator_2023());

employeeWithSOLID.Name = "CodeCell";
employeeWithSOLID.HourseWorked = 8;
employeeWithSOLID.HourlyRate = 40_000;

Console.WriteLine(employeeWithSOLID.GetSalary());



Console.ReadKey();
