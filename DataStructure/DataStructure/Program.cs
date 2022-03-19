
using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Programs!");
            Console.WriteLine("1.Balanced Paranthesis");
            Console.WriteLine("2.Banking Cash Counter");
            Console.WriteLine("3.Palindrome Checker");
            Console.WriteLine("4.print calender");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {

                case 1:
                    char[] expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
                    BalancingParanthese.StackOperations stackOperations = new BalancingParanthese.StackOperations();
                    bool result = stackOperations.Isbalanced(expression);
                    if (result)
                    {
                        Console.WriteLine("Parantheses Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parantheses not Balanced");
                    }
                    break;
                case 2:
                    BankCashCounter banking = new BankCashCounter();
                    banking.MaintainQueue();
                    break;
                case 3:

                    PalindromeChecker checker = new PalindromeChecker();
                    checker.IsPalindrome();
                    break;
                case 4:
                    Calender.PrintCalender();
                    break;

            }
        }
    }
}

   