using System;
using System.Collections.Generic;

namespace TC6_Stack
{
    class StackNotas
    {
        List<string> notas = new List<string>();

        // Agregar elemento
        // Quitar elemento
        // Ver elemento de arriba
        // Pop -> Ver + Quitar
        // Saber cuantos elementos tiene dentro

        public int Count {
            get => this.notas.Count;
        }

        // Imprimir stack

        public void Push(string nota)
        {
            // La parte de arriba del Stack es el final de la List
            this.notas.Add(nota);
        }

        public string Pop() //Pop - quitar el valor que está arriba y devolverlo
        {
            // 1. Devolver valor
            // 2. Borrar

            // ...Excepto cuando no hay nada que borrar
            if (this.notas.Count == 0)
            {
                return null;
            }

            // Respaldar valor
            string value = this.notas[this.notas.Count - 1];
            // Borrar de la lista
            this.notas.RemoveAt(this.notas.Count - 1);
            // Devolver el valor respaldado
            return value;
            // ^^La función llega hasta aquí^^
        }

        public string Peek()
        {
            // Count 5 -> 4
            // Count 3 -> 2
            // Count 0 -> ???
            if (this.notas.Count == 0)
            {
                Console.WriteLine("No hay elementos en el Stack");
                return null;
            }
            else
            {
                return this.notas[this.notas.Count - 1];
            }
        }

        public void PrintStack()
        {
            // Esto funciona, pero en un ambiente con múltiples usuarios no es óptimo.
            notas.Reverse();
            foreach (string nota in notas)
            {
                Console.WriteLine("");
                Console.WriteLine(nota);
            }
            Console.WriteLine("");
            notas.Reverse();
        }
    }
}