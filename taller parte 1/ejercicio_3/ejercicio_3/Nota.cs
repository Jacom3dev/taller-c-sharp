using System;

namespace ejercicio_3
{
    /*DADAS LAS 3 NOTAS DE UN APRENDIZ, CALCULE LA DEFINITIVA DE LA ASIGNATURA*/
    class Nota
    {
      
      
        public static float NotaDefinitiva(float nota1, float nota2,float nota3)
        {

            float def = (nota1 + nota2 + nota3) / 3;
            return def;
        }
        static void Main(string[] args)
        {
            float nota1, nota2, nota3;

            Console.Write("Nota1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Nota2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Nota3: ");
            nota3 = float.Parse(Console.ReadLine());

            NotaDefinitiva(nota1, nota2, nota3);

        }
    }
}
