using System;

namespace ejemplo3_T2
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor_com;

            Console.WriteLine("por favor ingresar el valor total de su compra:");
            valor_com = double.Parse(Console.ReadLine());

            if (valor_com >= 1000000)
            {

                valor_com = (valor_com - descuento(valor_com)) + IVA(valor_com);

                System.Console.WriteLine("lo total a pagar es " + valor_com);

                Console.ReadKey();
            }
            else
            {



                valor_com = valor_com + IVA(valor_com);

                System.Console.WriteLine("lo total a pagar es " + valor_com);
                Console.ReadKey();
            }
            static double IVA(double valor_com)
            {
                double r = (valor_com * 19) / 100;

                return r;
            }
            static double descuento(double valor_com)
            {

                double f = (valor_com * 10) / 100;


                return f;
            }

        }
    }
}
