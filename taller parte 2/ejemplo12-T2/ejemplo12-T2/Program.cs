using System;

namespace ejemplo12_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            Console.WriteLine("ingresar su altura");
            altura = double.Parse(Console.ReadLine());

            if (altura > 1.70) { mensaje1(); } else { mensaje2(); }
        }
        static void mensaje1()
        {
            Console.WriteLine("usted es una persona alta "); Console.ReadKey();

        }
        static void mensaje2()
        {
            Console.WriteLine("eres bajo"); Console.ReadKey();
        }
    }
}
