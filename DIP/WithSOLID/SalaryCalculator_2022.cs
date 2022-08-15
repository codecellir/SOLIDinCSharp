namespace DIP.WithSOLID
{
    public class SalaryCalculator_2022 : ISalary
    {
        public float CalculatorSalary(float hourseWorked, float hourlyRate)
        {
            return hourseWorked * hourlyRate;
        }
    }
}
