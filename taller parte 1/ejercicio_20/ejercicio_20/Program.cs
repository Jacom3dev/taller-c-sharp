using System;

namespace ejercicio_20
{
    class Program
    {
        /*INGRESAR EL PRECIO DE COMPRA UNITARIO DE UN PRODUCTO Y LA CANTIDAD DE COMPRA DE DICHO PRODUCTO Y UN DESCUENTO.
         CALCULAR Y MOSTRAR EL SUBTOTAL, EL MONTO DEL IVA QUE ES EL 19% DEL SUBTOTAL, Y EL PRECIO NETO
        (PRECIO PARCIAL CON EL MONTO DEL IVA)*/

        public static void Producto()
        {
            string nombreProducto;
            int precio, cantidad, descuento;
            float descuentoCompra, subtotal, total,iva;

            Console.Write("Prodcuto: ");
            nombreProducto = Console.ReadLine();

            Console.Write("Precio: ");
            precio = int.Parse(Console.ReadLine());

            Console.Write("cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.Write("descuento: ");
            descuento =  int.Parse(Console.ReadLine());

            descuentoCompra = ((precio * cantidad) * descuento) / 100;
            subtotal = (precio * cantidad) - descuentoCompra;
            iva = subtotal * 0.19F;
            total = subtotal + iva;

            Console.WriteLine("Subtotal: "+subtotal);
            Console.WriteLine("Iva: " + iva);
            Console.WriteLine("total: " + total);

        }

        static void Main(string[] args)
        {
            Producto();
        }
    }
}
