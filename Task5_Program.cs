using System;
using System.Linq;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu, ievadi skaitli");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
                        
            bool aValidRange = (a >= 50 && a < 100); 
            
            Console.WriteLine(aValidRange);

        }
    }
}
