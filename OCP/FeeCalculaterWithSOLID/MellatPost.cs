namespace OCP.FeeCalculaterWithSOLID
{
    public class MellatPost : IPaymentType
    {
        public double GetTransactionFee(double amount)
        {
            return amount * 0.5;
        }
    }
}
