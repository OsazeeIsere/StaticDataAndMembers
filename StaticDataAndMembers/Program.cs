using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.SetBufferSize(400, 1200);
            Console.SetWindowSize(80, 50);
            Console.WriteLine("=> Fun with Static Data \n");
            SavingsAccount s1 = new SavingsAccount(50);
            //print the current interest rate
            Console.WriteLine("Interest Rate is:{0}", SavingsAccount.GetInterestRate());

            //make a new object. this does not reset the interest rate.
            SavingsAccount s3 = new SavingsAccount(1000.75);
            Console.WriteLine("Interest Rate is:{0}", SavingsAccount.GetInterestRate());
            
            //try to change the interest rate via property.
            SavingsAccount.SetIntterestRate(0.08);
            SavingsAccount s2 = new SavingsAccount(100);

            //should print out 0.08....right??
            Console.WriteLine("Interest Rate After trying to reset the interest rate is:{0}", SavingsAccount.GetInterestRate());


            Console.ReadLine();



        }
    }
}
