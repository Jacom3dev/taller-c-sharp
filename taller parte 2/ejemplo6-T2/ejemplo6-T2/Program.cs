using System;

namespace ejemplo6_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorbruto;
            Console.WriteLine("ingrese el valor bruto del empleado:");
            valorbruto = double.Parse(Console.ReadLine());
            if (valorbruto >= 2000000)
            {
                
                valorbruto = valorbruto - retencion(valorbruto);

                System.Console.WriteLine("el valor a total que puede sacar es: " + valorbruto);

                Console.ReadKey();
            }
            else {
                System.Console.WriteLine("el valor a total que puede sacar es: " + valorbruto);

                Console.ReadKey();
            }
            static double retencion(double valorbruto) {

                double r = (valorbruto * 10) / 100;
                return r;
            }
        }
    }
}
