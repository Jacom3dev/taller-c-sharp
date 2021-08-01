using System;

namespace ejemplo7_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            if (num < 0) { mensaje(); }
        }
        static void mensaje() {

            Console.WriteLine("el numero es negativo"); Console.ReadKey();
        }
    }
}
