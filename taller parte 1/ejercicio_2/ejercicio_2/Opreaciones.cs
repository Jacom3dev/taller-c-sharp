using System;

namespace ejercicio_2
{
    /*LEA DOS NÚMEROS Y CALCULE EL RESULTADO DE SU SUMA, RESTA, MULTIPLICACIÓN Y DIVISIÓN.*/
    class Opreaciones
    {
        
        public static void Operaciones(int num1, int num2)
        {
            float suma, resta, multi, divi;

            suma = num1 + num2;
            resta = num1 - num2;
            multi = num1 * num2;
            divi = num1 / num2;

            Console.WriteLine("\nSuma: " + suma +
                              "\nResta: " + resta +
                              "\nMultiplicacion: " + multi +
                              "\nDivision: " + divi);
        }
       
      

        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Dita un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Dita otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            Operaciones(num1, num2);
        }
    }
}
