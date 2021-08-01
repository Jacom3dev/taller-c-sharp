using System;

namespace ejercicio_4
{
    class NotaDef
    {
        /*DADAS LAS 3 NOTAS DE UN APRENDIZ, CALCULE LA DEFINITIVA DE LA ASIGNATURA SI LA PRIMERA NOTA
         TIENE UN VALOR DEL 20%, LA SEGUNDA DEL 30% Y LA ÚLTIMA DEL 50%.*/
        
        

        public static float NotaDefinitiva(float nota1,float  nota2,float  nota3)
        {
            float def = (nota1*0.2F) + (nota2*0.3F) + (nota3*0.5F);

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

            NotaDefinitiva(nota1,nota2,nota3);

        }
    }
}
