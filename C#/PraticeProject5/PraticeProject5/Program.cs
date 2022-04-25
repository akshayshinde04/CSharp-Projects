using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeProject5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter your number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if (num1 < 0 )
            {
                Console.WriteLine("Number is negative ");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadLine();
        }


    }
}
