using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasYRespuestas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, not = 0, cont = 0;

            string[] preguntas = new string[3];
            string[] respuestas = new string[9];
            int[] respuestasAlumnos = new int[3];
            int[] respuestasC = new int[3];

            Console.WriteLine("\nBienvenidos al sistema de preguntas y respuestas");

            do
            {
                Console.WriteLine("- - - - - Menú - - - - -");
                Console.WriteLine("1) Cargar preguntas");
                Console.WriteLine("2) Responder preguntas");
                Console.WriteLine("3) Salir");

                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("\nCargar preguntas");

                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"\nPregunta {i + 1}:");
                            preguntas[i] = Console.ReadLine();

                            // Opciones de la pregunta
                            Console.WriteLine("\nCargue 3 opciones para responder esta pregunta");

                            if (i == 0)
                            {
                                for (int o = 0; o < 3; o++)
                                {
                                    Console.WriteLine($"\nRespuesta {o + 1}:");
                                    respuestas[o] = Console.ReadLine();
                                }
                            }
                            else if (i == 1)
                            {
                                for (int o = 3; o < 6; o++)
                                {
                                    Console.WriteLine($"\nRespuesta {o - 2}:");
                                    respuestas[o] = Console.ReadLine();
                                }
                            }
                            else if (i == 2)
                            {
                                for (int o = 6; o < 9; o++)
                                {
                                    Console.WriteLine($"\nRespuesta {o - 5}:");
                                    respuestas[o] = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("< - - - - - - - - - - - - - - - >");
                            Console.WriteLine("Indique el número de la respuesta correcta:");
                            respuestasC[i] = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nResponder preguntas");
                        Console.WriteLine("< - - - - - - - - - - - - - - - >");
                        do
                        {
                            int cont2 = 1;
                            Console.WriteLine(preguntas[cont]);
                            Console.WriteLine("\nOpciones:");

                            if (cont == 0)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            else if (cont == 1)
                            {
                                for (int i = 3; i < 6; i++)
                                {
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            else if (cont == 2)
                            {
                                for (int i = 6; i < 9; i++)
                                {
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            
                            Console.WriteLine("Elija su respuesta");
                            respuestasAlumnos[cont] = int.Parse(Console.ReadLine());
                            cont = cont + 1;

                        } while (cont != 3);

                        //evaluar
                        for (int i = 0; i < 3; i++)
                        {
                            if (respuestasC[i] == respuestasAlumnos[i])
                            {
                                Console.WriteLine(preguntas[i]);
                                Console.WriteLine("Respuesta correcta");
                                not = not + 2;
                            }
                            else
                            {
                                Console.WriteLine(preguntas[i]);
                                Console.WriteLine("Respuesta incorrecta, la respuesta correcta era: ");
                                Console.WriteLine(respuestasC[i]);
                            }
                            Console.WriteLine("< - - - - - - - - - - - - - - - >");

                        }
                        Console.WriteLine("Su nota final es: " + not);
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (a != 3);
        }
    }
}
