using System;

namespace ejercicio_16
{
    class Recaudo
    {
        /*SUPONGA QUE UN CONDUCTOR LE PIDE A USTED QUE LE HAGA UN ALGORITMO PARA CALCULAR CUÁNTO LE CORRESPONDE
         EN UN DÍA TRABAJADO, TENIENDO EN CUENTA QUE TIENE DERECHO A EL 19% DEL TOTAL RECAUDADO.*/

        public static void PedirRecaudo()
        {
            float recaudo;
            Console.WriteLine("Digite el Valor Recaudado");
            recaudo = float.Parse(Console.ReadLine());

            recaudo = recaudo*0.19F;

            Console.WriteLine("a usted le corresponde: "+recaudo+"$");
        }
        static void Main(string[] args)
        {
            PedirRecaudo();
        }
    }
}
