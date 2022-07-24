namespace OCP.FeeCalculaterWithSOLID
{
    public class MeliPOS : IPaymentType
    {
        public double GetTransactionFee(double amount)
        {
            return amount * 0.4;
        }
    }
}
