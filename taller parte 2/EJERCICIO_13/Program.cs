using System;

namespace EJERCICIO_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*una constructora ofrece vivienda de interes social bajo las siguientes condiciones
            si los ingresos del comprador son iguales o superiores a 1.200000,  la cuota inicial sera de 15%
            de valor de la vivienda y el resto, se distribuira en 120 cuotas mensuales con un interes de 2% mensual
            
            si los ingresos del comprador son inferiores a 1.200000
            la cuota inicial sera de 30% del valor de la vivienda
            el resto lo distribuira en 84 cuotas mensuales con un interes de 1% mensual.

            la constructora decea saber cuanto debe pagar un comprador por concepto de cuota inicial 
            y cuanto x cada cuota mensual*/

            Double ingresos,cuotaInicial,cuotaMensual,valorVivienda;
            Console.WriteLine("ingrese el valor de la vivienda");
            valorVivienda=double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de ingresos del comprador");
            ingresos=double.Parse(Console.ReadLine());
            if (ingresos>=1200000)
            {
                cuotaInicial=valorVivienda*0.15;
                cuotaMensual=((valorVivienda-cuotaInicial)/12*10)*0.2;
            }else
            {
                cuotaInicial=valorVivienda*0.30;
                cuotaMensual=((valorVivienda-cuotaInicial)/12*7)*0.1;
            }
            System.Console.WriteLine("la cuota inicial del comprador es "+cuotaInicial);
            System.Console.WriteLine("la cuota mensual del comprador es "+cuotaMensual);


        }
    }
}
