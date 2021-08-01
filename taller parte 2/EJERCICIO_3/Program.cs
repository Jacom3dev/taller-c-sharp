using System;

namespace EJERCICIO_3
{
    class Program
    {/*elavore un algoritmo q lea un numero y si este es mayor o igual a 10 devuelva el triple de este, 
    de lo contrario la cuarta parte de este*/
        static void Main(string[] args)
        {
           int num;
           Console.WriteLine("ingrese un numero");
           num=int.Parse(Console.ReadLine());

           if (num>=10)
           {num=num*3;
               
           }else
           {
               num=num/4;
           }
           System.Console.WriteLine("NUMERO DEVUELTO ES "+num);
        }
    }
}
