using System;

namespace numeroRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroRandom = random.Next(1, 100);
            int numero,contrador=0;

            Console.WriteLine(numeroRandom+" Es El Numero Ganador");
            bool salir = true;

            Console.Write("Adivina el Numero: ");
            numero = int.Parse(Console.ReadLine());

            while (salir)
            {
                contrador++;

                if (numero>numeroRandom)
                {
                    Console.WriteLine("\n el numero se ecuentra por debajo");
                }else if (numero<numeroRandom)
                {
                    Console.WriteLine("\n el numero se ecuentra por encima ");
                }
                else
                {
                    Console.WriteLine("GANASTE!!");
                    Console.WriteLine($"Intentos {contrador}");
                    salir = false;
                }

                if (salir)
                {
                    Console.Write("Adivina el Numero: ");
                    numero = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}
