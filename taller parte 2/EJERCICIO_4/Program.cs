using System;

namespace EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*realizar un algoritmo que lea dos numeros y los imprima en orden ascendente*/
            int num1, num2;
            Console.WriteLine("ingrese el primer numero");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            num2=int.Parse(Console.ReadLine());
            if (num1<num2)
            {System.Console.WriteLine("\n"+num1+"\n"+num2);
                
            }else
            {
                System.Console.WriteLine("\n"+num2+"\n"+num1);
            }

        }
    }
}
