using System;

namespace EJERCICIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*calcular e imprimir el salario de un empleado teniendo en cuenta que si el salario bruto
            es igual o superior a 2.000000, debe hacerse una retencion de 10%, 
            si el salario es inferior la retencion sera de 3%*/
            Double salario, retencion, salarioFinal;
            Console.WriteLine("ingrese el valor de su salario");
            salario=double.Parse(Console.ReadLine());

            if (salario>2000000)
            {retencion=salario*0.10;
                salarioFinal=salario-retencion;
            }else if (salario<2000000)
            {
                retencion=salario*0.3;
                salarioFinal=salario-retencion;
            }
            
            System.Console.WriteLine("el valor de su salario es "+salario);
        }
    }
}
