using System;

namespace EJERCICIO_7
{
    class Program
    {
        static void Main(string[] args)
        {
           /*leer un numero e imprimir un mensaje si es par o impar*/
           int num;
           Console.WriteLine("escriba un numero");
           num=int.Parse(Console.ReadLine());
           if ((num%2)==0)
           {System.Console.WriteLine("SU NUMERO "+num+" ES PAR");
               
           }else
           {
               System.Console.WriteLine("SU NUMERO "+num+" ES IMPAR");
           }
        }
    }
}
