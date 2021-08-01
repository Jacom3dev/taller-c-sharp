using System;

namespace ejercicio_15
{
    class Compra
    {
        /*SUPONGA QUE TIENE UD. UNA TIENDA Y DESEA REGISTRAR LAS VENTAS EN UNA COMPUTADORA. DISEÑE UN ALGORITMO EN PSEUDOCÓDIGO QUE LEA POR CADA CLIENTE: 
        •	EL MONTO DE LA VENTA, CALCULE E IMPRIMA EL IVA.
        •	CALCULE E IMPRIMA EL TOTAL A PAGAR 
        •	LEA LA CANTIDAD CON LA QUE PAGA EL CLIENTE (SOLO EFECTIVO), CALCULE E IMPRIMA EL CAMBIO*/
        public static void CompraVenta()
        {
            int cantidadProductos;
            string producto;
            float valor,montoVenta=0,IVA,billete,devuelta;

            Console.Write("¿Cantidad de productos a comprar?: ");
            cantidadProductos = int.Parse(Console.ReadLine());

            string[] nombreProductos = new string[cantidadProductos];
            float[] valorProductos = new float[cantidadProductos];

            for(int i = 0; i < nombreProductos.Length; i++)
            {
                Console.Write("Nombre Producto: ");
                producto = Console.ReadLine();
                nombreProductos[i] = producto;

                Console.Write("Valor Producto: ");
                valor = float.Parse(Console.ReadLine());
                valorProductos[i] = valor;
                Console.WriteLine("");
            }

            for (int i = 0; i < nombreProductos.Length; i++)
            {
                montoVenta +=  valorProductos[i];
            }

            Console.WriteLine("valor del Billete");
            billete = float.Parse(Console.ReadLine());

            while (billete<montoVenta)
            {
                Console.WriteLine("Billete insuficiente");
                Console.Write("Digite valor billete: ");
                billete = float.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            devuelta = billete - montoVenta;
            IVA = montoVenta * 0.19F;

            Console.WriteLine("");
            Console.WriteLine("Monto: " + montoVenta+"\nIVA: "+IVA+"\nDevuelta: "+devuelta);
          
        }
        static void Main(string[] args)
        {
            CompraVenta();
        }
    }
}
