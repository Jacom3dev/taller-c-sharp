using System;

namespace EJERCICIO_8
{
    class Program
    {
        static void Main(string[] args)
        {
           /*elaborar un algoritmo que permita calcular el numero de pulsaciones que debe tener unaa persona
           por cada 10 segundos de ejercicio aerobico; 
           la formula q c aplica cuando el sexo es femenino es: numpulsaciones=(220-edad)/10
           si el sexo es masculino numpulsaciones=(210-edad)/10*/
           int edad, numpulsaciones;
           string sexo;
           Console.WriteLine("ingrese su sexo");
           sexo=(Console.ReadLine());
           Console.WriteLine("ingrese su edad");
           edad=int.Parse(Console.ReadLine());
           if (sexo="femenino")
           {
               numpulsaciones=(220-edad)/10;
               
           }else if (sexo="masculino")
           {
               numpulsaciones=(210-edad)/10;
           }
           System.Console.WriteLine("el numero de pulsaciones que ud debe tener por cada 10 segundos es de "+numpulsaciones);
        }
    }
}
