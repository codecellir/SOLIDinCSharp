namespace DIP.WithoutSOLID
{
    public class Employee
    {
        public string Name { get; set; }
        public float HourseWorked { get; set; }
        public float HourlyRate { get; set; }
        public float GetSalary()
        {
            Salary salary = new Salary();
            return salary.CalculateSalary(HourseWorked, HourlyRate);
        }
    }
}
