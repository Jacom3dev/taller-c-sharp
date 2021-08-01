using System;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {/*hacer un algoritmo que calcule el total a pagar por la compra de camisas. 
        si se compran tres camisetas o mas aplica un descuento del 20% sobre el total de la compra
        si son menos de tres camisetas un descuento del 10%*/
            int cantArticulo;
            Double valorNeto,totalApagar,descuento;
            Console.WriteLine("ingrese el valor de su compra");
            valorNeto=double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de camisetas compradas");
            cantArticulo=int.Parse(Console.ReadLine());

            if (cantArticulo>=3)
            {descuento=valorNeto*0.20;
                
            }else if (cantArticulo<3)
            {descuento=valorNeto*0.10;
                
            }else
            {
                descuento=valorNeto*0.0;
            }
            totalApagar=valorNeto-descuento;
            System.Console.WriteLine("EL TOTAL A PAGAR ES: "+totalApagar);


        }
    }
}
