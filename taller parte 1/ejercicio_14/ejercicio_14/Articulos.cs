using System;

namespace ejercicio_14
{
    class Articulos
    {
        /*SE TRATA DE ESCRIBIR EL ALGORITMO QUE PERMITA EMITIR LA FACTURA CORRESPONDIENTE A UNA COMPRA DE VARIOS 
         ARTÍCULOS (4) DETERMINADOS, DEL QUE SE ADQUIEREN UNA O VARIAS UNIDADES. EL IVA ES DEL 19%. */
       

        public static void ArticulosVenta()
        {
            string articulo;
            float valorArticulo;
            float cantidadArticulo;
            float valorTotal = 0;
            String[] articulos = new string[4];
            float[] valorArticulos = new float[4];
            float[] cantidadArticulos = new float[4];

            for(int i=0;i<articulos.Length;i++)
            {
                Console.Write("Nombre Articulo: ");
                articulo = Console.ReadLine();
                articulos[i] = articulo;

                Console.Write("Valor Articulo: ");
                valorArticulo = float.Parse(Console.ReadLine());
                valorArticulos[i] = valorArticulo;

                Console.Write("Cantidad Articulo: ");
                cantidadArticulo = float.Parse(Console.ReadLine());
                cantidadArticulos[i] = cantidadArticulo;
                Console.WriteLine("");
            }
            Console.WriteLine("........................");
            for (int i = 0; i < articulos.Length; i++)
            {
                valorTotal += valorArticulos[i] * cantidadArticulos[i];
                Console.WriteLine(articulos[i]+ "  "+ cantidadArticulos[i] + " $" + (valorArticulos[i] * cantidadArticulos[i]));
            }
            Console.WriteLine("Total a pagar: "+(valorTotal-(valorTotal*0.19)));
            Console.WriteLine("........................");


        }
        static void Main(string[] args)
        {
            ArticulosVenta();
        }
    }
}
