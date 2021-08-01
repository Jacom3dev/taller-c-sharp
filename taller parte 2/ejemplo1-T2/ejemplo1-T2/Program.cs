using System;

namespace ejemplo1_T2
{
    class Program
    {

        static void Main(string[] args)
        {
            int nu;
            nu = int.Parse(Console.ReadLine());
            residuo(nu);

            if (residuo(nu) == 0)
            {
                Console.WriteLine("Es Par");
            }
            Console.ReadKey();

        }
        static int residuo(int nu)
        {

            nu = nu % 2;

            return nu;

        }
    }
}
