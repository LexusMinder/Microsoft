//Librerias
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program //Inicio de clase
    {
        static void Main(string[] args)
        {//Inicio de main

            //Declaracion de lista de tipo string
            var names = new List<string> { "Julio", "Edgar", "Saul" };
            Console.WriteLine();

            //Metodos para añadir a lista y remover de la misma
            names.Add("Hector");
            names.Add("Axel");
            names.Remove("Edgar");

            //Ciclo para poder acceder a la lista y mostrar su contenido
            foreach (var name in names) //Sirve para acceder al Array de manera sencilla sin index
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
            Console.WriteLine($"The list has {names.Count} people in it");

            //Metodo para buscar en una lista
            var index = names.IndexOf("Julio");

            //Si regresa algo diferente de menos uno, quiere decir que existe en esa lista
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            //Si regresa menos uno quiere decir que NO existe en esa lista
            var notFound = names.IndexOf("This dont exists");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort(); //Metodo que acomoda de manera ordenada las listas. Modifica el orden de la misma

            foreach (var name in names)
                Console.WriteLine($"hello {name.ToUpper()}!");

            //Se crea una lista de integers
            var fibonnanciNumbers = new List<int> { 1, 1 };

            //Challengue: imprime los primeros 20 numeros de la serie de fibonnanci 
            while (fibonnanciNumbers.Count < 20)
            {
                var previous = fibonnanciNumbers[fibonnanciNumbers.Count - 1];//Se guarda el ultimo indice de la lista
                var previous2 = fibonnanciNumbers[fibonnanciNumbers.Count - 2];//Se guarda el penultimo indice de la lista

                fibonnanciNumbers.Add(previous + previous2);//Lo añade al arreglo
            }

            //Imprime cada item de la lista ya modificada 
            foreach (var item in fibonnanciNumbers)
                Console.WriteLine(item);

        }//Fin de main
    }//Fin de class
}
