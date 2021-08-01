using System;

namespace ejemplo11_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = 0;
            double[] num=new double[4];
            for (int i = 0; i < 4; i++) {
               System.Console.WriteLine("ingresar un numero ");
               num[i] = double.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < 4; i++)
            {
                promedio =num[i]+promedio;

            }
            
            if (prome(promedio) >= 3.5)
            {
                Console.WriteLine("usted a aprobado");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("usted a perdido");
                Console.ReadKey();
            }
            static double prome(double primedio) {

                double p = primedio / 4;
                return p;
            }
           
        }
    }
}
