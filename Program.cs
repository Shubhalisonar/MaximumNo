using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNo
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd Number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("The 1st Number is the greatest . \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest . \n\n");
                }
            }
            else if (b > c)
                Console.Write("The 2nd Number is the greatest \n\n");
            else
                Console.Write("The 3rd Number is the greatest \n\n");
            Console.ReadLine();
        }
        
    }
}

        