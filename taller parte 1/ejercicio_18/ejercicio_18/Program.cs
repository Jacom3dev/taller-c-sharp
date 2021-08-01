using System;

namespace ejercicio_18
{
    class Program
    {
        /*EN UNA UNIVERSIDAD LOS ESTUDIANTES PUEDEN PAGAR EL VALOR DE SU MATRÍCULA EN CUATRO CUOTAS DE
        LA SIGUIENTE FORMA 
        •	PRIMERA CUOTA: 40% 
        •	SEGUNDA CUOTA: 25%
        •	 TERCERA CUOTA: 20% 
        •	CUARTA CUOTA: 15% */
        public static void Cuotas()
        {
            float valorMatricula;

            Console.Write("Valor Matricula: ");
            valorMatricula = float.Parse(Console.ReadLine());

            Console.WriteLine("Primera Cuota: " + (valorMatricula * 0.4));
            Console.WriteLine("Segunda Cuota: " + (valorMatricula * 0.25));
            Console.WriteLine("Tercera Cuota: " + (valorMatricula * 0.2));
            Console.WriteLine("Primera Cuota: " + (valorMatricula * 0.15));
        }


        static void Main(string[] args)
        {
            Cuotas();
        }
    }
}
