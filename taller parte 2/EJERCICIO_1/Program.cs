using System;

namespace EJERCICIO_1
{
    class Program
    {/*hacer un algoritmo que imprima el nombre de un articulo, 
    clave,precio origunal y su precio con descuento.
    El descuento lo hace en base a la clave, si la clave es 01 el descuento es 10%
     si la clave es 02 el descuento es de 20%(solo existen 2 claves)*/
        static void Main(string[] args)
        {
           String nombre;
           int clave;
           Double precioNeto,precioTotal,descuento;
           Console.WriteLine("Ingrese el nombre del articulo");
           nombre=(Console.ReadLine());
           Console.WriteLine("ingrese la clave (01 o 02)");
           clave=int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese el precio del articulo");
           precioNeto=double.Parse(Console.ReadLine());
           
           if (clave==01)
           {descuento=precioNeto*0.10;
               
           }else if (clave==02)
           {
               descuento=precioNeto*0.20;
               
           }else
           {
               Console.WriteLine("LO SENTIMOS ESE ARTICULO NO POSEE DESCUENTO");
               descuento=0.0;
           }
           precioTotal=precioNeto-descuento;
           System.Console.WriteLine("el nombre del articulo es "+nombre);
           System.Console.WriteLine("La clave del articulo es "+clave);
           System.Console.WriteLine("El precio con descuento es "+precioNeto);
           System.Console.WriteLine("el precio con descuento es "+precioTotal);
           System.Console.WriteLine("--------FIN DEL PROGRAMA-----------");
        }
    }
}
