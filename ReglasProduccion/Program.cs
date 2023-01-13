using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ReglasProduccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regla1 = "ABDe";
            string regla2 = "aaf";
            string regla3 = "Aeb";
            string regla4 = "ddf";
            string regla5 = "ffg";
            int opcion;

            

            for(int j = 0; j < 5; j++)
            {
                int minusculas = 0, mayusculas = 0;

                Console.WriteLine("Reglas de Produccion: \n");
                Console.WriteLine("1. Mostrar reglas de produccion");
                Console.WriteLine("2. Detalle de las reglas de produccion");
                Console.WriteLine("3. Salir\n");

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Reglas de produccion: " +
                            "\n1. S " + regla1 +
                            "\n2. A " + regla2 +
                            "\n3. A " + regla3 +
                            "\n4. B " + regla4 +
                            "\n5. D " + regla5);
                        break;
                    case 2:
                        int regla = 1;
                        do
                        {
                            Console.WriteLine("1. Regla principal");
                            Console.WriteLine("2. Regla 2");
                            Console.WriteLine("3. Regla 3");
                            Console.WriteLine("4. Regla 4");
                            Console.WriteLine("5. Regla 5");
                            Console.WriteLine("6. Volver a inicio\n");

                            regla = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            
                            switch (regla)
                            {
                                case 1:
                                    Console.WriteLine("Regla principal: ");
                                    for (int i = 0; i < regla1.Length; i++)
                                    {
                                        if ((regla1[i].Equals('A') || (regla1[i].Equals('B')) || regla1[i].Equals('C') ||
                                            regla1[i].Equals('D') || (regla1[i].Equals('E'))))
                                        {
                                            mayusculas++;
                                        }
                                        else
                                        {
                                            if ((regla1[i].Equals('a') || (regla1[i].Equals('b')) || regla1[i].Equals('c') ||
                                             regla1[i].Equals('d') || (regla1[i].Equals('e'))))
                                            {
                                                minusculas++;
                                            }
                                        }
                                    }
                                    Console.WriteLine("Contiene " + mayusculas + " No terminales" + " y " + minusculas + " terminales");
                                    Console.ReadLine();
                                    if (mayusculas >= 0 && minusculas >= 0)
                                    {
                                        mayusculas = 0;
                                        minusculas = 0;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Regla 2: ");
                                    for (int i = 0; i < regla2.Length; i++)
                                    {
                                        if ((regla2[i].Equals('A') || (regla2[i].Equals('B')) || regla2[i].Equals('D') ||
                                            regla2[i].Equals('E') || (regla2[i].Equals('F'))))
                                        {
                                            mayusculas++;
                                        }
                                        if ((regla2[i].Equals('a') || (regla2[i].Equals('b')) || regla2[i].Equals('d') ||
                                             regla2[i].Equals('e') || (regla2[i].Equals('f'))))
                                        {
                                            minusculas++;
                                        }
                                    }
                                    Console.WriteLine("Contiene " + mayusculas + " No terminales" + " y " + minusculas + " terminales");
                                    Console.ReadLine();
                                    if (mayusculas >= 0 && minusculas >= 0)
                                    {
                                        mayusculas = 0;
                                        minusculas = 0;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Regla 3: ");
                                    for (int i = 0; i < regla3.Length; i++)
                                    {
                                        if ((regla3[i].Equals('A') || (regla3[i].Equals('B')) || regla3[i].Equals('C') ||
                                            regla3[i].Equals('D') || (regla3[i].Equals('E'))))
                                        {
                                            mayusculas++;
                                        }
                                        if ((regla3[i].Equals('a') || (regla3[i].Equals('b')) || regla3[i].Equals('c') ||
                                             regla3[i].Equals('d') || (regla3[i].Equals('e'))))
                                        {
                                            minusculas++;
                                        }
                                    }
                                    Console.WriteLine("Contiene " + mayusculas + " No terminales" + " y " + minusculas + " terminales");
                                    Console.ReadLine();
                                    if (mayusculas >= 0 && minusculas >= 0)
                                    {
                                        mayusculas = 0;
                                        minusculas = 0;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Regla 4: ");
                                    for (int i = 0; i < regla4.Length; i++)
                                    {
                                        if ((regla4[i].Equals('A') || (regla4[i].Equals('B')) || regla4[i].Equals('D') ||
                                            regla4[i].Equals('E') || (regla4[i].Equals('F'))))
                                        {
                                            mayusculas++;
                                        }
                                        if ((regla4[i].Equals('a') || (regla4[i].Equals('b')) || regla4[i].Equals('d') ||
                                             regla4[i].Equals('e') || (regla4[i].Equals('f'))))
                                        {
                                            minusculas++;
                                        }
                                    }
                                    Console.WriteLine("Contiene " + mayusculas + " No terminales" + " y " + minusculas + " terminales");
                                    Console.ReadLine();
                                    if (mayusculas >= 0 && minusculas >= 0)
                                    {
                                        mayusculas = 0;
                                        minusculas = 0;
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Regla 5: ");
                                    for (int i = 0; i < regla5.Length; i++)
                                    {
                                        if ((regla5[i].Equals('A') || (regla5[i].Equals('B')) || regla5[i].Equals('D') ||
                                            regla5[i].Equals('F') || (regla5[i].Equals('G'))))
                                        {
                                            mayusculas++;
                                        }
                                        if ((regla5[i].Equals('a') || (regla5[i].Equals('b')) || regla5[i].Equals('d') ||
                                             regla5[i].Equals('f') || (regla5[i].Equals('g'))))
                                        {
                                            minusculas++;
                                        }
                                    }
                                    Console.WriteLine("Contiene " + mayusculas + " No terminales" + " y " + minusculas + " terminales");
                                    Console.ReadLine();
                                    if (mayusculas >= 0 && minusculas >= 0)
                                    {
                                        mayusculas = 0;
                                        minusculas = 0;
                                    }
                                    break;
                            }
                        } while (regla < 6);
                        break;
                    case 3: return;
                }
                Console.WriteLine("\nPulse una tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
