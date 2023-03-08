using System;
using System.Globalization;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu ievadi pirmo skaitli");
            int a = Convert.ToInt32(Console.ReadLine());

            bool Monthnumber = (a >= 1 && a <= 12);

            if (Monthnumber)

            {
                string monthname = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(a);
                Console.WriteLine(monthname);

            }

            else

            {

                Console.WriteLine("Tu ievadīji nepareizu skaitli - tāda mēneša nav!");
            }

        }
    }
}
