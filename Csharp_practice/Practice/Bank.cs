using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Practice
{
     class Bank
    {
        private int marks
        {
            get
            {
                return marks;
            }
            set
            {
                if(marks>100 || marks < 0)
                {
                    Console.WriteLine("invalid marks");
                }
                else
                {
                    marks = value;
                }
            }
        }

        public static void displaymarks()
        {
            //Console.WriteLine(this.marks);
        }


        int id;

        string name;

        double balance;

        public Bank(int id, string name, double balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string Deposit(double amount)
        {
            if (amount <= 0)
            {
                return "please enter valid amount ";
            }
            else
            {
                this.balance = this.balance + amount;
                return "successfully deposited the amoubt the total amount " +  this.balance;
            }
        }

        public string Withdraw(double amount)
        {
            if(amount > this.balance || amount == 0)
            {
                return " withdraw is failed please enter valid amount";
            }
            else if(amount < 0)
            {
                return " please select the amount more than 0";
            }
            else
            {
                this.balance = this.balance - amount;
                return "succefully completed the withdraw the current balance " + this.balance; 
            }

        }

        public void Displaybalance()
        {
            Console.WriteLine(this.balance); 
        }

    }



    class BankProgram
    {
        public static void Main()
        {
            Bank obj = new Bank(11, "mahendra", 10000);
            obj.Displaybalance();

            string Deposit = obj.Deposit(110);
            Console.WriteLine(Deposit);
            obj.Displaybalance();

           string wirthdraw =  obj.Withdraw(11);

           
            Console.WriteLine(wirthdraw);
            obj.Displaybalance();
        }
    }
}
