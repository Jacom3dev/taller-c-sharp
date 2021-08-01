using System;

namespace ejercicio_5
{
    /*LEA LA DISTANCIA (EN KILÓMETROS) RECORRIDA POR UN AUTO, EL TIEMPO (EN HORAS) EN QUE LA RECORRIÓ Y CALCULE 
     LA VELOCIDAD A LA CUAL SE DESPLAZABA EL AUTO (V=D/T).*/
    class Velocidad
    {
      
        public static void Formula(float distancia,float tiempo)
        {
            float velocidad = distancia / tiempo;
            Console.WriteLine(velocidad+"Km/h");
        }
        static void Main(string[] args)
        {
            float distacia, tiempo;

            Console.Write("Distancia recorrida: ");
            distacia = float.Parse(Console.ReadLine());


            Console.Write("Tiempo Demorado: ");
            tiempo= float.Parse(Console.ReadLine());


            Formula(distacia,tiempo);
        }
    }
}
