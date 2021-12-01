using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Oop
{
    enum ACC_TYPE  {SAVINGS,CURRENT};
    class Account
    {

        private int accNo;
        private string ahName;
        private ACC_TYPE accType = ACC_TYPE.SAVINGS;
        private int balance;

        static int minBalance = 10000;


        public Account(int accNo, string ahName)
        {
            this.accNo = accNo;
            this.ahName = ahName;
            this.balance = 0;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (balance > amount)
                balance -= amount;
        }

        public int getBalance()
        {
            return balance;
        }

        static int getMinBal()
        {
            return minBalance;
        }

        public int Number
        {
            get { return accNo; }
        }
        public void Print()
        {
            Console.WriteLine($"A/C No:{this.Number} ({this.ahName})    - INR{getBalance()}");
        }


    }

    class testAccount
    {

        static void Main(string[] args)
        {
            var a1 = new Account(1001, "Tom Mills");
            a1.Deposit(35000);
            a1.Print();

            a1.Withdraw(2000);
            a1.Print();
        }
    }
}
