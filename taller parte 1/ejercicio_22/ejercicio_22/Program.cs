using System;

namespace ejercicio_22
{
    class Program
    {

        /*SE TIENEN TRES BALDES DE AGUA, UNO DE CINCO LITROS, OTROS DE TRES LITROS Y OTRO DE UN LITRO;
        SI EL DE UN LITRO TARDA UNA HORA Y MEDIA EN LLENARSE, RESUELVA CUANTO TIEMPO PUEDEN TARDAR EN LLENARSE LOS
        OTROS BALDES. 
        SI TIENE TRES BALDES, PERO SE DESCONOCE SU TAMAÑO DEBE DE RESOLVER IGUALMENTE EL EJERCICIO. */

        public static void Baldes()
        {
            float[] baldes = new float[3];


            Console.WriteLine("Capacidad de litros de los Baldes De agua");
            for (int i = 0;i< baldes.Length; i++){
                Console.Write("Balde " + (i + 1) + ": ");
                baldes[i] = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < baldes.Length; i++)
            {
                Console.Write("Balde " + (i + 1) + ": ");
                Console.WriteLine((baldes[i] * 1.5)+"Horas");
            }
        }
        static void Main(string[] args)
        {

            Baldes();
        }
    }
}
