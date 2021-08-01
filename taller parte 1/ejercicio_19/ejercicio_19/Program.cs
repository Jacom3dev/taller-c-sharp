using System;

namespace ejercicio_19
{
    class Program
    {
        /*INGRESAR, PARA UN ESTUDIANTE, SUS 5 NOTAS DE UN CURSO, NOMBRE, PROGRAMA, FICHA.  HACER UN ALGORITMO QUE:
        MUESTRE EL NOMBRE
        MUESTRE EL PROGRAMA DE FORMACIÓN

        SE DEBE CALCULAR Y MOSTRAR SU PROMEDIO FINAL.
        */

        public static void Estudiante()
        {
            string nombre,programa,ficha;
            float[] notas = new float[5];
            float promedio  = 0;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Programa: ");
            programa = Console.ReadLine();

            Console.Write("Ficha: ");
            ficha = Console.ReadLine();

            Console.WriteLine("Digite las notas");

            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                notas[i] = float.Parse(Console.ReadLine());
                promedio += notas[i];
            }

            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Programa: " + promedio);
            Console.WriteLine("Ficha: " + ficha);
            Console.WriteLine("Promedio: " + (promedio/5));
        }
        static void Main(string[] args)
        {
            Estudiante();
        }
    }
}
