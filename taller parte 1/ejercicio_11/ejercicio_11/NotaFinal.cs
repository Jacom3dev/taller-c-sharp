using System;

namespace ejercicio_11
{
    class NotaFinal
    {
        /*UN ALUMNO DESEA SABER CUÁL SERÁ SU CALIFICACIÓN FINAL EN LA MATERIA DE ALGORITMOS. 
        DICHA CALIFICACIÓN SE COMPONE DE LOS SIGUIENTES PORCENTAJES:
	    55% DEL PROMEDIO DE SUS TRES CALIFICACIONES PARCIALES.
 	    30% DE LA CALIFICACIÓN DEL EXAMEN FINAL. 
	    15% DE LA CALIFICACIÓN DE UN TRABAJO FINAL*/

        public static void PedirValores()
        {
            float notas, promedioParcial = 0,examenFinal,trabajoFinal,calificacionFinal; 

           
            float[] notasParcial = new float[3];
            Console.WriteLine("Calificaciones de parciales");

            for(int i=0;i<notasParcial.Length;i++)
            {
                Console.Write("Digite nota"+(i+1)+": ");
                notas = float.Parse(Console.ReadLine());
                notasParcial[i] = notas;
            }
            for (int i = 0; i < notasParcial.Length; i++)
            {
                promedioParcial += notasParcial[i];
            }

            Console.Write("Calificacion de Examen Final");
            examenFinal = float.Parse(Console.ReadLine());

            Console.Write("nota  trabajo Final: ");
            trabajoFinal = float.Parse(Console.ReadLine());

            calificacionFinal = (((promedioParcial/3)*0.55F)+(examenFinal*0.3F)+(trabajoFinal*0.15F));
            Console.WriteLine("Calificacion Final: " + calificacionFinal);
        }
        static void Main(string[] args)
        {
            PedirValores();
        }
    }
}
