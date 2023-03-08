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

                for (a = n - n; a <= n; a++)
            {
                Console.WriteLine(a);

            }
            

        }
    }
}
