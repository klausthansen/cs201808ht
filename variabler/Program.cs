using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalMaanederPrAar = 12;
            System.Int32 a = 1;
            int a2 = 2;


            Console.WriteLine(a);
            Console.WriteLine("a =  " +a);
            Console.WriteLine($"a =  {a}");


            int y = 10;

            //instans medlem//
            Console.WriteLine(y.ToString);
            //statisk medlem//
            Console.WriteLine(int.MaxValue);

            double z = 7971343.14158394080;

            Console.WriteLine(z);
            Console.WriteLine(z.ToString());
            Console.WriteLine(z.ToString("N2"));
            Console.WriteLine(z.ToString("N3"));
            Console.WriteLine(z.ToString("F2"));
            Console.WriteLine(z.ToString("C2"));



            Console.ReadKey();


        }
    }
}
