using System;

namespace ejemplo5_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_com;
            Console.WriteLine("por favor ingresar el valor a pagar:");
            valor_com = double.Parse(Console.ReadLine());
            if (valor_com >= 100000)
            {
                
                valor_com = valor_com - descuento(valor_com);

                System.Console.WriteLine(" el valor a pagar es de : " + valor_com);
                Console.ReadKey();
            }
            else { System.Console.WriteLine(" el valor a pagar es de : " + valor_com);  Console.ReadKey(); }
        }
        static double descuento(double valor_com) {

            double d = (valor_com * 20) / 100;


            return d;
        }
    }
}
