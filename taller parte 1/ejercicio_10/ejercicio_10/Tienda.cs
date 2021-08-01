using System;

namespace ejercicio_10
{
    class Tienda
    {
        /*UNA TIENDA OFRECE UN DESCUENTO DEL 15% SOBRE EL TOTAL DE LA COMPRA Y UN CLIENTE DESEA SABER CUÁNTO DEBERÁ
         PAGAR FINALMENTE POR SU COMPRA.*/

        public static void Pago(double valor)
        {
            valor -= (valor * 0.15);
            Console.WriteLine("Usted debera pagar: " + valor);
        }
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Valor compra: ");
            valor = double.Parse(Console.ReadLine());

            Pago(valor);
        }
    }
}
