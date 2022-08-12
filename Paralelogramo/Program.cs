using System;

namespace Paralelogramo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray;
            string opc = "";
            bool error;

            do
            {
                Console.WriteLine("Dibuja las filas con #.");
                Console.WriteLine("1)Calcular área 2)Reiniciar 3)Salir");
                error = false;
                int i = 0;
                int ancho = 0;
                int alto = 0;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    opc = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (opc == "1" || opc == "2" || opc == "3" || opc.Contains('*'))
                    {
                        if (opc != "1" && opc != "2" && opc != "3")
                        {
                            charArray = opc.ToCharArray();

                            if (VerificarCadena(charArray) == false)
                            {
                                if (i == 0)
                                {
                                    ancho = charArray.Length;
                                }
                                else
                                {
                                    if (charArray.Length != ancho)
                                    {
                                        Console.WriteLine("El ancho debe mantenerse a la misma medida.");
                                        error = true;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                alto++;
                                i++;
                            }
                            else
                            {
                                error = true;
                                Console.Clear();
                            }
                        }

                        if (opc == "1")
                        {
                            Console.WriteLine("El área del paralelogramo es: {0}.", ancho * alto);
                        }

                        if (opc == "2")
                        {
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Selecciona una opción válida.");
                    }

                } while (error != true && opc != "1" && opc != "2" && opc != "3");

            } while (error == true || opc == "2" || opc == "1");
        }

        static Boolean VerificarCadena(char[] simbolos)
        {
            char symbol = '*';
            foreach (char simbolo in simbolos)
            {
                if (simbolo != symbol)
                {
                    Console.WriteLine("Toda la figura debe estar formada con el caracter *.");
                    Console.ReadKey();
                    return true;
                }
            }

            return false;
        }
    }
}
