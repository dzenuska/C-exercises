using System;
using System.Linq;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu, ievadi skaitli");
            int n; int a;
            n = Convert.ToInt32(Console.ReadLine());

            bool positive = (n >= 0);

            if (positive)

            {
                for (a = n - n; a <= n; a++)
                {
                    Console.WriteLine(a);
                }

            }
                
            
            if (!positive)
            
            {
                for (a = n; a <= 0; a++)
                
                {
                    
                Console.WriteLine(a);
                }

            }

        }
    }
}
