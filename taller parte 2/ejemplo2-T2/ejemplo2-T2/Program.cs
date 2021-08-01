using System;

namespace ejemplo2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 ;
            num1 = int.Parse(Console.ReadLine());
            
            if (num1 >= 10) {   System.Console.WriteLine("su triple es: "+mult(num1)); }

            Console.ReadKey();
        }

        static double mult(int num1) {

            double r = Math.Pow(num1, 3);

            return r;
        }
        
    }
}
