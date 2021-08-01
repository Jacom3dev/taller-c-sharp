using System;

namespace ejercicio_21
{
    class Program
    {
        /*REALICE UN ALGORITMO QUE PERMITA REALIZAR EL CÁLCULO DEL SIGUIENTE ENUNCIADO, SE SOLICITA EL AÑO DE NACIMIENTO
         DEL APRENDIZ, EL NOMBRE, LA DIRECCIÓN, SE REQUIERE CONOCER LA EDAD DE LA PERSONA Y LA INFORMACIÓN COMPLETA 
        INGRESADA. */

        public static void Aprendiz()
        {
            string nombre,direcion;
            int yearNacimiento;
            int year = DateTime.Now.Year;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("direccion: ");
            direcion = Console.ReadLine();

            Console.Write("Año de nacimento: ");
            yearNacimiento = int.Parse(Console.ReadLine());


            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("direccion: " + direcion);
            Console.WriteLine("Edad: " + (year-yearNacimiento));

        }
        static void Main(string[] args)
        {
            Aprendiz();
        }
    }
}
