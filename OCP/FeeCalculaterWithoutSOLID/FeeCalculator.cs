namespace OCP.FeeCalculaterWithoutSOLID
{
    public class FeeCalculator
    {
        public double GetTransactionFee(double amount, PaymentType type)
        {
            double transactionFee = 0;

            if (type == PaymentType.Meli)
            {
                transactionFee = amount * 0.4;
            }
            else if (type == PaymentType.Mellat)
            {
                transactionFee = amount * 0.5;
            }
            else if (type == PaymentType.Saman)
            {
                transactionFee = amount * 0.8;
            }
            return transactionFee;
        }
    }
}
