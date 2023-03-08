using System;
using System.Linq;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lūdzu, ievadi otro skaitli");
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lūdzu, ievadi trešo skaitli");
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            
            bool aeq = (a == b || a == c); 
            bool beq = (b == a || b == c);
            bool ceq = (c == a || c == b);

            if (aeq)

            {
                a = 0;

            }

            if (beq)
            {
                b = 0;
        
            }

            if (ceq)

            {
                c = 0;
            }

            Console.WriteLine("Lūk, Tavs rezultāts: " + (a + b + c));

        }
    }
}
