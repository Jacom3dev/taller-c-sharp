using System;

namespace EJERCICIO_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*una persona enferma cuyo peso es 70kg, se encuentra en reposo y decea saber cuantas calorias consume
            su cuerpo durante el tiempo que realice una misma actividad. 
            las actividades que puede realizar son unicamente dormir o estar sentado.
            los datos q tienen son que estando dormido consume 1.08 calorias*minuto
            estando sentado en reposo consume 1.66 calorias*minuto*/
            double time,timemin,cg;
            string activity1="dormido", activity2="sentado",activity;

            Console.WriteLine("ingrese la actividad que ejerce actualmente \n -dormido\n -sentado");
            activity=(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de horas en  las que ejerce su actividad");
            time=double.Parse(Console.ReadLine());

            if (activity==activity1)
            {
                timemin=time *60;
                cg=timemin*1.08;

            }else if (activity==activity2)
            {
                timemin=time *60;
                cg=timemin*1.66;
                
            }else
            {
                System.Console.WriteLine("LA ACTIVIDAD NO ESTA DISPONIBLE EN EL PROGRAMA");
                 timemin=time *60;
                 cg=timemin*0.0;
            }
            System.Console.WriteLine("la cantidad de calorias gastadas es de "+cg);



        }
    }
}
