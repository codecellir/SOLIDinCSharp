namespace DIP.WithSOLID
{
    public class SalaryCalculator_2023 : ISalary
    {
        public float CalculatorSalary(float hourseWorked, float hourlyRate)
        {
            return hourseWorked * hourlyRate*(float)1.2;
        }
    }
}
