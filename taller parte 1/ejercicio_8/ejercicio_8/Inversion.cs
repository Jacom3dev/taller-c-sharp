using System;

namespace ejercicio_8
{
    class Inversion
    {
        /*SUPONGA QUE UN INDIVIDUO DESEA INVERTIR SU CAPITAL EN UN BANCO Y DESEA SABER CUÁNTO DINERO GANARÁ
         DESPUÉS DE UN MES SI EL BANCO PAGA A RAZÓN DE 2% MENSUAL.*/

        public static void MostrarDinero(float inversion)
        {
            float ganancias = inversion * 0.02F;
            Console.WriteLine("Ganancias: " + ganancias);
        }

        static void Main(string[] args)
        {
            float inversion;

            Console.Write("Dinero a invertir: ");
            inversion = float.Parse(Console.ReadLine());

            MostrarDinero(inversion);
        }

    }   
     
}
