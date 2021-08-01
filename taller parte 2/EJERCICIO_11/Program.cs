using System;

namespace EJERCICIO_11
{
    class Program
    {
        static void Main(string[] args)
        {/*una empresa decea hacer una compra de varias piezas de la misma clase a una fabrica
        la empresa dependiendo del valor de la compra decidira la forma en q le pagara al fabricante 
        si el valor de la compra excede o es sigual a 5.000000 
        la empresa tendraa la capacidad de pagar con recussos propios el 55% del valor d la compra
        pedira prestado a un banco el 30% y el resto pagara solicitando un credito al fabricante

        si el monto total d la compra no excede de 5.000000 
        la empresa tendra la capacidad de pagar con recursos propios un 70% y 
        el 30%restante lo pagara solicitando un credito al fabricante

        el fabricante cobra un 15% d interes sobre la cantidad que le pague a credito.
        */
        int cantPiezas;
        Double Costo, Total, Invertir,Prestamo,Credito,Interes;
        Console.WriteLine("ingrese la cantidad de piezas");
        cantPiezas=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el costo por pieza");
        Costo=double.Parse(Console.ReadLine());
        Total=cantPiezas*Costo;
        if (Total>5000000)
        {
            Invertir=Total*0.55;
            Prestamo=Total*0.30;
            Credito=Total*0.15;

            
        }else
        {
            Invertir=Total*0.70;
            Prestamo=0;
            Credito=Total*0.30;
        }
        Interes=Credito*0.20;
        System.Console.WriteLine("la cantidad a invertir es "+Invertir+"\nla cantidad de su prestamo es de "+Prestamo+"\nla cantidad a credito es "+Credito+"\nla cantidad de interes es "+Interes);
        System.Console.WriteLine("---------------------------FIN ALGORITMO-------------------------------");




        
        }
    }
}
