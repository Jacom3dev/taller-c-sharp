using System;

namespace ejercicio_1
{
    /*LEA TRES NÚMEROS Y CALCULE EL RESULTADO DE SU SUMA*/
    class Suma
    {
        public static void Calcular(int num1, int num2, int num3)
        {
            float result;
            result = num1 + num2 + num3;
            Console.WriteLine("Resultado: " + result);
        }

        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Digita el primer Numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita el primer Segundo");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita el primer tercer");
            num3 = int.Parse(Console.ReadLine());

            Calcular(num1, num2, num3);
           
        }
    }
}
