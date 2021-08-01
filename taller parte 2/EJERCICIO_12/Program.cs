using System;

namespace EJERCICIO_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*elavorar un algoritmo que permita calcular el valor total a pagar en una papeleria
             teniendo en cuenta que 
             si lleva 5 cuadernos o mas se le cobraran 2000x cada uno 
             mientras que si se lleva menos se cobrara 2500x cada uno*/
             Double vTotal, cantCuadernos;
             Console.WriteLine("ingrese la cantidad de cuadernos que llevará ");
             cantCuadernos=int.Parse(Console.ReadLine());
             if (cantCuadernos>=5)
             {
                 vTotal=cantCuadernos*2000;
                 
             }else
             {
                 vTotal=cantCuadernos*2500;
             }
             System.Console.WriteLine("el valor total de su compra es "+vTotal);
        }
    }
}
