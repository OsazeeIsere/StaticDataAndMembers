using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        //instance-level data.
        public double currBalance;
        //A static point of data
        public static double currInterestRate;
        //custom constructor
        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04;//this is static data
            currBalance = balance;
        }
        //A static constructor
         static  SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;//this is static data
        }
        //creating  static methods
        public static double GetInterestRate() => currInterestRate; //expression-bodied method
        public static void SetIntterestRate(double newRate) => currInterestRate = newRate;
    }
}
