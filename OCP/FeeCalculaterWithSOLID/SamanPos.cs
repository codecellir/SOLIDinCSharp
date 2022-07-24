namespace OCP.FeeCalculaterWithSOLID
{
    public class SamanPos : IPaymentType
    {
        public double GetTransactionFee(double amount)
        {
            return amount * 0.8;
        }
    }
}
