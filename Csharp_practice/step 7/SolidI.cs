using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_7
{
    interface IPayments
    {
        void Pay(double amount);
    }

    interface IRefund
    {
        void Refund(double amount);
    }

    interface IStatement
    {
        void GenerateStatement();
    }

    class CreditCard : IPayments, IRefund, IStatement
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Credit card payment: " + amount);
        }

        public void Refund(double amount)
        {
            Console.WriteLine("Credit card refund: " + amount);
        }

        public void GenerateStatement()
        {
            Console.WriteLine("Credit card statement generated");
        }
    }

    class UPI : IPayments, IRefund
    {
        public void Pay(double amount)
        {
            Console.WriteLine("UPI payment: " + amount);
        }

        public void Refund(double amount)
        {
            Console.WriteLine("UPI refund: " + amount);
        }
    }

    class SolidI
    {
        public static void Main()
        {
            CreditCard card = new CreditCard();
            card.Pay(5000);
            card.Refund(1000);
            card.GenerateStatement();

            UPI upi = new UPI();
            upi.Pay(2000);
            upi.Refund(500);
        }
    }
}
