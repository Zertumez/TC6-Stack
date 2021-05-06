using System;

namespace TC6_Stack
{
    class Program
    {
        
    }
    class MenúInteractivo
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Introduce tu nombre:");
            // string nombre = Console.ReadLine();
            // Console.WriteLine("Hola " + nombre);

            // 1) Decir "Hola Mundo!"
            // 2) Decir "HHola [nombre]!"
            // 9) Salir

            // while

            // Mostrar el menú de opciones
            // Solicitar la opción al usuario

            StackNotas stackNotas = new StackNotas();
            stackNotas.Push("Primer nota");
            stackNotas.Push("Segunda nota");
            stackNotas.Push("Tercer nota");

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                // Pedir opción al usuario
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                {
                    // Escapar caracter "
                    // Que lo que sigue de la diagonal inversa te lo tomen como caracter
                    Console.WriteLine("1) Imprimir notas (PrintStack)");
                    Console.WriteLine("2) Agregar nota (Push)");
                    Console.WriteLine("3) Quitar nota (Pop)");
                    Console.WriteLine("4) Consultar un elemento (Peek)");
                    Console.WriteLine("9) Salir");

                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    // Validar opción ingresada 
                    // hasta que se introduzca una opción correcta
                    // (mientras no se haya introducido una opción correcta)
                    if (opcion != "1" && opcion != "2" && opcion != "3"  && opcion != "4" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta.");
                    }

                }

                // Manejar la opción seleccionada
                if (opcion == "1")
                {
                    stackNotas.PrintStack();
                }
                else if (opcion == "2")
                {
                    // Push
                    Console.WriteLine("Agregar nota:");
                    string nota = Console.ReadLine();
                    stackNotas.Push(nota);
                }
                else if (opcion == "3")
                {
                    // Pop
                    string nota = stackNotas.Pop();
                    Console.WriteLine("Nota removida");
                    Console.WriteLine(nota);
                }
                else if (opcion == "4")
                {
                    // Peek
                    string nota = stackNotas.Peek();
                    Console.WriteLine("Nota consultada:");
                    Console.WriteLine(nota);
                }
                else if (opcion == "9")
                {
                    Console.WriteLine("Hasta luego!");
                }
                else
                {

                }

                // switch (opcion)
                // {
                //     case "1":
                //         // Hacer algo para la opción 1
                //         break;
                //     case "2":
                //         // Hacer algo para la opción 2
                //         break;
                //     case "9":
                //         // Hacer algo para la opción 9
                //         break;
                //     default:
                //         // Hacer algo para la opción 1
                //         break;
                // }
            }

        }
    }
}
