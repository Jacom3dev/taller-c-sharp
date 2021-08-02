using System;

namespace parte3
{
    class Program
    {
        public static void NumerosPrimos()
        {
            int n = 2, total = 1, num;

            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            for (int r = 1; r < num; r++)
            {


                bool esPrimo = true;


                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }


                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }

                n++;
            }
        }
        public static void Sueldos()
        {
            byte cantidadSueldos;
            float sueldoMayor = 0;
            Console.Write("Cantidad de sueldos: ");
            cantidadSueldos = byte.Parse(Console.ReadLine());
            float[] sueldos = new float[cantidadSueldos];

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Sueldo " + (i + 1) + ": ");
                sueldos[i] = float.Parse(Console.ReadLine());

                if (sueldos[i]>sueldoMayor)
                {
                    sueldoMayor = sueldos[i];
                }

            }
            Console.WriteLine("Sueldo mayor es: "+sueldoMayor);
        }

        public static void NumerosLetras()
        {
            int numero = 0;
            Console.WriteLine("Ingresa un numero entre 1 y 99: ");
            numero = int.Parse(Console.ReadLine());
            int decena = numero / 10;
            int unidad = numero - (decena * 10);
            string decenaLetra = null;
            string unidadLetra = null;

       

            if (decena == 1)
            {
                if (unidad == 0)
                {
                    decenaLetra = "diez";
                }
                if (unidad == 1)
                {
                    decenaLetra = "once";
                }
                if (unidad == 2)
                {
                    decenaLetra = "doce";
                }
                if (unidad == 3)
                {
                    decenaLetra = "trece";
                }
                if (unidad == 4)
                {
                    decenaLetra = "catorce";
                }
                if (unidad == 5)
                {
                    decenaLetra = "quince";
                }
                if (unidad == 6)
                {
                    decenaLetra = "dieciseis";
                }
                if (unidad == 7)
                {
                    decenaLetra = "diecisiete";
                }
                if (unidad == 8)
                {
                    decenaLetra = "dieciocho";
                }
                if (unidad == 9)
                {
                    decenaLetra = "diecinueve";
                }
            }
            else if (decena ==2)
            {
                decenaLetra = "veinti";
                if (unidad == 0)
                {
                    decenaLetra = "veinte";
                }
            }
            else if (decena == 3)
            {
                decenaLetra = "treinta y ";
                if (unidad == 0)
                {
                    decenaLetra = "treinta";
                }
            }
            else if (decena == 4)
            {
                decenaLetra = "cuarenta y ";
                if (unidad == 0)
                {
                    decenaLetra = "cuarenta";
                }
            }
            else if (decena == 5)
            {
                decenaLetra = "cincuenta y ";
                if (unidad == 0)
                {
                    decenaLetra = "cincuenta";
                }
            }
            else if (decena == 6)
            {
                decenaLetra = "secenta y ";
                if (unidad == 0)
                {
                    decenaLetra = "secenta";
                }
            }
            else if (decena == 7)
            {
                decenaLetra = "setenta y ";
                if (unidad == 0)
                {
                    decenaLetra = "setenta";
                }
            }
            else if (decena == 8)
            {
                decenaLetra = "ochenta y ";
                if (unidad == 0)
                {
                    decenaLetra = "ochenta";
                }
            }
            else if (decena == 9)
            {
                decenaLetra = "noventa y ";
                if (unidad == 0)
                {
                    decenaLetra = "noventa";
                }
            }
            else
            {
                decenaLetra = "";
            }

            if (unidad == 1)
            {
                unidadLetra = "uno";
            }
            if (unidad == 2)
            {
                unidadLetra = "dos";
            }
            if (unidad == 3)
            {
                unidadLetra = "tres";
            }
            if (unidad == 4)
            {
                unidadLetra = "cuatro";
            }
            if (unidad == 5)
            {
                unidadLetra = "cinco";
            }
            if (unidad == 6)
            {
                unidadLetra = "seis";
            }
            if (unidad == 7)
            {
                unidadLetra = "siete";
            }
            if (unidad == 8)
            {
                unidadLetra = "ocho";
            }
            if (unidad == 9)
            {
                unidadLetra = "nueve";
            }
            if (decena==1)
            {
                unidadLetra = null;
            }
            Console.WriteLine(decenaLetra+unidadLetra);
        }

        public static void LetrasAbecedario()
        {
            char letra ;
            Console.WriteLine("Ingresa  una letra del abecedario. ");
            letra = char.Parse( Console.ReadLine());

            if (letra.Equals('a') || letra.Equals('e') || letra.Equals('i') || letra.Equals('o') || letra.Equals('u'))
            {
                Console.WriteLine(letra + " es una vocal. ");
            }
            else
            {
                Console.WriteLine(letra + " es una consonante. ");
            }

        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine(".........................\n"+
                              "1)nueros primos\n"+
                              "2)sueldos\n"+
                              "3)mostrar numeros\n"+
                              "4)letra abecedario\n"+
                              "..........................");
            Console.Write("Elige un numero: ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion ==1)
            {
                NumerosPrimos();
            }
            else if (opcion==2)
            {
                Sueldos();
            }
            else if (opcion == 3)
            {
                NumerosLetras();
            }
            else if (opcion == 4)
            {
                LetrasAbecedario();
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}
