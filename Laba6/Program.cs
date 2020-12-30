using System;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a0 = Console.ReadLine();

            Lines A1 = new Lines(a0);
            Figures A2 = new Figures(a0);
            Letters A3 = new Letters(a0);

            Console.WriteLine(A1.ToString());

            a0 = A2.DeletSimbol5(a0);
            A2 = new Figures(a0);
            Console.WriteLine(A2.ToString());

            a0 = A3.DeletSimbolA(a0);
            A3 = new Letters(a0);
            Console.WriteLine(A3.ToString());

            Console.ReadKey();



        }
    }
}
