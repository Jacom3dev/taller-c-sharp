using System;

namespace parte4
{
    class Program
    {
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

                if (sueldos[i] > sueldoMayor)
                {
                    sueldoMayor = sueldos[i];
                }

            }
            Console.WriteLine("Sueldo mayor es: " + sueldoMayor);
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

            switch (decena)
            {
                case 1:
                    switch (unidad)
                    {
                        case 0:
                            decenaLetra = "diez";
                            break;
                        case 1:
                            decenaLetra = "once";
                            break;
                        case 2:
                            decenaLetra = "doce";
                            break;
                        case 3:
                            decenaLetra = "trece";
                            break;
                        case 4:
                            decenaLetra = "catorce";
                            break;
                        case 5:
                            decenaLetra = "quince";
                            break;
                        case 6:
                            decenaLetra = "dieciseis";
                            break;
                        case 7:
                            decenaLetra = "diecisiete";
                            break;
                        case 8:
                            decenaLetra = "dieciocho";
                            break;
                        case 9:
                            decenaLetra = "diecinueve";
                            break;

                    }

                    break;
                case 2:

                    decenaLetra = "veinti";
                    if (unidad == 0)
                    {
                        decenaLetra = "veinte";
                    }
                    break;
                case 3:

                    decenaLetra = "treinta y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "treinta";
                    }
                    break;
                case 4:

                    decenaLetra = "cuarenta y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "cuarenta";
                    }
                    break;
                case 5:

                    decenaLetra = "cincuenta y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "cincuenta";
                    }
                    break;
                case 6:

                    decenaLetra = "secenta y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "secenta";
                    }
                    break;
                case 7:

                    decenaLetra = "setenta y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "setenta";
                    }
                    break;
                case 8:

                    decenaLetra = "ochenta y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "ochenta";
                    }
                    break;
                case 9:

                    decenaLetra = "noventa y ";
                    if (unidad == 0)
                    {
                        decenaLetra = "noventa";
                    }
                    break;

                default:
                    decenaLetra = "";
                    break;
            }
            switch (unidad )
            {
                case 1:
                    unidadLetra = "uno";
                    break;
                case 2:
                    unidadLetra = "dos";
                    break;
                case 3:
                    unidadLetra = "tres";
                    break;
                case 4:
                    unidadLetra = "cuatro";
                    break;
                case 5:
                    unidadLetra = "cinco";
                    break;
                case 6:
                    unidadLetra = "seis";
                    break;
                case 7:
                    unidadLetra = "siete";
                    break;
                case 8:
                    unidadLetra = "ocho";
                    break;
                case 9:
                    unidadLetra = "nueve";
                    break;
            }

            if (decena == 1)
            {
                unidadLetra = null;
            }
            Console.WriteLine(decenaLetra + unidadLetra);
        }

        public static void LetrasAbecedario()
        {
            char letra;
            Console.WriteLine("Ingresa  una letra del abecedario. ");
            letra = char.Parse(Console.ReadLine());

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
            Console.WriteLine("##################\n" +
                              "1)nueros primos\n" +
                              "2)sueldos\n" +
                              "3)mostrar numeros\n" +
                              "4)letra abecedario\n" +
                              "###################");
            Console.Write("Elige un numero: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    
                break;
                case 2:
                    Sueldos();
                break;
                case 3:
                    NumerosLetras();
                break;
                case 4:
                    LetrasAbecedario();
                break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
