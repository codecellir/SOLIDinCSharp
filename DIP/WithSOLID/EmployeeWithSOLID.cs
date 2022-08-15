namespace DIP.WithSOLID
{
    public class EmployeeWithSOLID
    {
        private readonly ISalary _salary;
        public string Name { get; set; }
        public float HourseWorked { get; set; }
        public float HourlyRate { get; set; }
        public EmployeeWithSOLID(ISalary salary)
        {
            _salary = salary;
        }
        public float GetSalary()
        {
            return _salary.CalculatorSalary(HourseWorked, HourlyRate);
        }
    }
}
