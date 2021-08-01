using System;

namespace ejercicio_13
{
    class Salario
    {
        /*DADA LAS HORAS TRABAJADAS DE UNA PERSONA Y EL VALOR POR HORA. CALCULAR SU SALARIO E IMPRIMIRLO.*/

        public static void ImprimirSalario()
        {
            int valorHora, horasTrabajadas;

            Console.Write("Valor hora: ");
            valorHora = int.Parse(Console.ReadLine());

            Console.Write("Horas Trabajadas: ");
            horasTrabajadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Salario: "+(valorHora*horasTrabajadas));
        }
        static void Main(string[] args)
        {
            ImprimirSalario();
        }
    }
}
