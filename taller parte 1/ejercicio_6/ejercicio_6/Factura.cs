using System;

namespace ejercicio_6
{
    /*LEA LA CANTIDAD DE DINERO CORRESPONDIENTE A UNA COMPRA Y CALCULE EL VALOR DEL IVA (19%), Y EL VALOR TOTAL DE
     LA FACTURA, SI AL VALOR DE LA COMPRA SE LE AUTORIZA UN DESCUENTO DEL 10% (ANTES DE APLICARLE EL IVA).*/
    class Factura
    {
        public static void MostrarFactura()
        {
            string respuesta;
            float descuento = 0;
            Console.Write("Valor compra: ");
            float valorCompra = float.Parse(Console.ReadLine());

            Console.Write("Aplicaras descuento a esta compra s/n"); 
            respuesta = Console.ReadLine();
            if(respuesta == "s")
            {
                descuento = valorCompra * 0.1F;
            }

            
        
            float valorApagar = valorCompra - descuento;
            Console.WriteLine("......................." +
                              "\ndescuento\t" + descuento +
                              "\npago con iva\t" + (valorApagar + (valorApagar * 0.19F)) +
                              "\n.......................");
        }
        static void Main(string[] args)
        {
            MostrarFactura();
        }
    }
}
