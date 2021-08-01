using System;

namespace EJERCICIO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera
            si trabaja 40 horas o menos, c le paga a 10 mil la hora
            si trabaja mas d 40horas  c le paga 10.000 x cada una de las primeras 40 horas 
             y 15.000 x cada una de las horas extra*/

             int horasTrabajadas,horasExtra;
             double saalarioSemanal, primerasHoras,pagoExtra;
             Console.WriteLine("ingrese el numero de horas trabajadas en la semana");
             horasTrabajadas=int.Parse(Console.ReadLine());
             if (horasTrabajadas<=40)
             {saalarioSemanal=10000*horasTrabajadas;
                 
             }else
             {
                 primerasHoras=10000*40;
                 horasExtra=horasTrabajadas-40;
                 pagoExtra=15000*horasExtra;
                 saalarioSemanal=primerasHoras+pagoExtra;
             }
             System.Console.WriteLine("Su salario de esta semana es: "+saalarioSemanal);

        }
    }
}
