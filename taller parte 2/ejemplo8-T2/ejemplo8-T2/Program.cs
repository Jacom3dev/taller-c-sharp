using System;

namespace ejemplo8_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("dinero a invertir:");
            valor = double.Parse(Console.ReadLine());

            do
            {
                
                
            } while (interes(valor) > 700000);

            System.Console.WriteLine("la cantidad total de dinero que tiene es: "+valorX(valor));
            Console.ReadKey();

        }
        static double interes(double valor) {

            double i = (valor * 9) / 100;
            return i;
        }
        static double valorX(double valor) {

            double v = valor + interes(valor);
            return v;
        }
    }
}
