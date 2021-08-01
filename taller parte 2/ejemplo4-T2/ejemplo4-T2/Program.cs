using System;

namespace ejemplo4_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) {  System.Console.WriteLine("la suma es: "+resul(num1,num2)); } else { Console.WriteLine("no se pueden sumar"); }
            Console.ReadKey();
        }
        static int resul(int num1, int num2) {

            int n = num1 + num2;
            return n;
        }
    }
}
