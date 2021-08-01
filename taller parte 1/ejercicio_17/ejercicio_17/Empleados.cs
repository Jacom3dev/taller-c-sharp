using System;

namespace ejercicio_17
{
    class Empleados
    {
        /*	DESARROLLAR UN ALGORITMO QUE PERMITA GENERAR LA COLILLA DE PAGO DE LOS EMPLEADOS DE UNA EMPRESA.
         LA COLILLA DEBE MOSTRAR:
         •	EL SALARIO DEL EMPLEADO 
         •	EL VALOR DE AHORRO MENSUAL PROGRAMADO.
         •	LA SUMA A DEDUCIR POR APORTE A LA SALUD (EPS) 12,5 %
         •	LA SUMA A DEDUCIR POR APORTE AL FONDO DE PENSIONES  16%
         •	TOTAL A RECIBIR 
         •	TODA LA INFORMACIÓN QUE DEBE PROVEER EL USUARIO DEL PROGRAMA ES EL  SALARIO DEL EMPLEADO Y EL VALOR DE
         AHORRO MENSUAL PROGRAMADO. EL PROGRAMA DEBE CALCULAR Y DEVOLVER EL RESTO DE LOS DATOS.4*/


        public static void Trabajador()
        {
            float salario, ahorro,eps,pension;

            Console.Write("Salario: ");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Ahorro: ");
            ahorro = float.Parse(Console.ReadLine());

            eps = (salario * 12.5F) / 100;
            pension = salario * 0.16F;

            Console.WriteLine("\nSalario: "+salario);
            Console.WriteLine("Ahorro Mensual: " + ahorro);
            Console.WriteLine("EPS: " + eps);
            Console.WriteLine("Pension: " + pension);
            Console.WriteLine("Total a recibir: " + (salario-(eps+pension+ahorro)));

        }
        static void Main(string[] args)
        {

            Trabajador();

        }
    }
}
