using System;

namespace ejercicio_7
{
    /*DADA UNA CANTIDAD DE TIEMPO MEDIDA EN HORAS, MINUTOS Y SEGUNDOS, DIGA A CUÁNTOS SEGUNDOS EQUIVALE.*/
    class Segundos
    {
        public static void MostrarSegundos()
        {
            int horas, minutos, segundos;

            Console.Write("Horas: ");
            horas = int.Parse(Console.ReadLine());

            Console.Write("Minutos: ");
            minutos = int.Parse(Console.ReadLine());

            Console.Write("Segundos: ");
            segundos = int.Parse(Console.ReadLine());

            int res = ((horas * 3600) + (minutos * 60) + segundos);
            Console.WriteLine(res + " Sedundos");
        }
        static void Main(string[] args)
        {
            MostrarSegundos();
        }
    }
}
