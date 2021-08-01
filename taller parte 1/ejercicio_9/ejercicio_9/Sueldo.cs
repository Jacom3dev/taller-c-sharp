using System;

namespace ejercicio_9
{
    /*UN VENDEDOR RECIBE UN SUELDO BASE MÁS UN 10% EXTRA POR COMISIÓN DE SUS VENTA,
     EL VENDEDOR DESEA SABER CUÁNTO DINERO OBTENDRÁ POR CONCEPTO DE COMISIONES POR LAS TRES
     VENTAS QUE REALIZA EN EL MES Y EL TOTAL QUE RECIBIRÁ EN EL MES TOMANDO EN CUENTA SU SUELDO BASE Y COMISIONES.*/
    class Sueldo
    {
        public static void MostrarSueldos(float sueldo,int venta1,int venta2,int venta3)
        {
            float comision = (venta1 + venta2 + venta3) * 0.1F;
            sueldo += comision;
            Console.WriteLine("Comision:\t"+comision);
            Console.WriteLine("Sueldo total:\t" + sueldo);
        }
        static void Main(string[] args)
        {
            float sueldo = 800000;
            int venta1, venta2, venta3;

            Console.Write("Valor venta1: ");
            venta1 = int.Parse(Console.ReadLine());

            Console.Write("Valor venta2: ");
            venta2 = int.Parse(Console.ReadLine());

            Console.Write("Valor venta3: ");
            venta3 = int.Parse(Console.ReadLine());

            MostrarSueldos(sueldo, venta1, venta2, venta3);
        }
    }
}
