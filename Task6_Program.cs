using System;
using System.Linq;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu, ievadi pirmo vārdu");
            string a;
            a = Console.ReadLine();
            Console.WriteLine("Lūdzu, ievadi otro vārdu");
            string b;
            b = Console.ReadLine();
                        
            if (a.Length > b.Length)

            {
                Console.WriteLine("\"{0}{1}{2}\"", b, a, b);
            }

            if (a.Length < b.Length)
            
            {
                Console.WriteLine("\"{0}{1}{2}\"", a, b, a);
            }
            
            if (a.Length == b.Length)

            {
                Console.WriteLine("\"{0}{1}{2}\"", a, b, a);
            }

        }
    }
}
