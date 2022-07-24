// See https://aka.ms/new-console-template for more information


using OCP.FeeCalculaterWithoutSOLID;
using OCP.FeeCalculaterWithSOLID;

FeeCalculator fc = new FeeCalculator();

Console.WriteLine("Without SOLID:\r\n");

Console.WriteLine(fc.GetTransactionFee(10_000, PaymentType.Meli));
Console.WriteLine(fc.GetTransactionFee(10_000, PaymentType.Mellat));
Console.WriteLine(fc.GetTransactionFee(10_000, PaymentType.Saman));

Console.WriteLine("\r\n\r\n\r\nWith SOLID:\r\n");

IPaymentType meli = new MeliPOS();
IPaymentType mellat = new MellatPost();
IPaymentType saman = new SamanPos();

Console.WriteLine(meli.GetTransactionFee(10_000));
Console.WriteLine(mellat.GetTransactionFee(10_000));
Console.WriteLine(saman.GetTransactionFee(10_000));

Console.ReadKey();
