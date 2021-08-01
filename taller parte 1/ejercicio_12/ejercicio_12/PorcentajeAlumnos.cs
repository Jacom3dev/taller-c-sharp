using System;

namespace ejercicio_12
{
    class PorcentajeAlumnos
    {

        public static void Porecentajes (int hombre,int mujeres)
        {
            int totalAlumnos = hombre + mujeres;
            float porcentajeHombres = (hombre * 100) / totalAlumnos;
            float porcentajeMujeres = (mujeres * 100) / totalAlumnos;
            Console.WriteLine("Hombres: " + porcentajeHombres + "%");
            Console.WriteLine("Mujeres: " + porcentajeMujeres + "%");
        }

        static void Main(string[] args)
        {
            Console.Write("Cantidad Hombre: ");
            int hombres = int.Parse(Console.ReadLine());

            Console.Write("Cantidad mujeres: ");
            int mujeres = int.Parse(Console.ReadLine());

            Porecentajes(hombres, mujeres);
        }
    }
}
