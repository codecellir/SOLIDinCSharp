namespace OCP.FeeCalculaterWithSOLID
{
    public interface IPaymentType
    {
        double GetTransactionFee(double amount);
    }
}
