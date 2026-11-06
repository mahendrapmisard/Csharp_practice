using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_7
{

    interface IPayment
    {
        void ProcessPayment(double amount);
    }

    class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Credit Card Payment: {amount}");
        }
    }

    class DebitCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Debit Card Payment: {amount}");
        }
    }

    class UPIPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"UPI Payment: {amount}");
        }
    }

    class NetBankingPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Net Banking Payment: {amount}");
        }
    }

    class PaymentProcessor
    {
        public void Process(IPayment payment, double amount)
        {
            payment.ProcessPayment(amount);
        }
    }

    class SolidO
    {
       public static void Main()
        {
            PaymentProcessor processor = new PaymentProcessor();

            IPayment creditCard = new CreditCardPayment();
            IPayment debitCard = new DebitCardPayment();
            IPayment upi = new UPIPayment();
            IPayment netBanking = new NetBankingPayment();

            processor.Process(creditCard, 5000);
            processor.Process(debitCard, 3000);
            processor.Process(upi, 2000);
            processor.Process(netBanking, 4000);
        }
    }
}
