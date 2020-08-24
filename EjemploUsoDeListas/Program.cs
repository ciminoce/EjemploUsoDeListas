using System;
using System.Collections.Generic;

namespace EjemploUsoDeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo del Uso de Listas");
            /*Definir una lista */
            var listaPersonas = new List<string>();
            /*Agrego datos a la lista usando el método Add*/
            listaPersonas.Add("Pedro");
            listaPersonas.Add("José");
            listaPersonas.Add("Santiago");
            listaPersonas.Add("Magdalena");
            listaPersonas.Add("Judas");
            listaPersonas.Add("María");

            MostrarLista(listaPersonas);

            listaPersonas.Add("Isaías");
            MostrarLista(listaPersonas);

            listaPersonas.Remove("Judas");
            MostrarLista(listaPersonas);
            /*remove es le método usado para borrar un elemento de la lista
             dicho método devuelve un bool indicando si pudo o no borrar el 
            elemento en cuestión*/

            var eliminado=listaPersonas.Remove("Marcelo");
            if (eliminado)
            {
                Console.WriteLine("Registro eliminado");
            }
            else
            {
                Console.WriteLine("Registro no eliminado");
            }

            /*El método IndexOf me devuelve el nro de elemento en el cual
             se encuentra el valor que le paso
            si el mismo no se encontrare devuelve -1*/
            var iIndex = listaPersonas.IndexOf("Marcelo");
            Console.WriteLine($"{iIndex}");
            iIndex = listaPersonas.IndexOf("María");
            Console.WriteLine($"{iIndex}");
            listaPersonas.Insert(2,"Joaquín");
            MostrarLista(listaPersonas);

            /*Modificación del contenido de un elemento de la lista
             Primero busco el elemento a modificar 
            luego le asigno un nuevo contenido*/
            iIndex = listaPersonas.IndexOf("María");
            listaPersonas[iIndex] = "Cecilia";
            MostrarLista(listaPersonas);


        }

        private static void MostrarLista(List<string> listaPersonas)
        {
            /*Mostrar los datos de la lista*/
            foreach (var persona in listaPersonas)
            {
                Console.WriteLine($"{persona}");
            }

            /*Ver la cantidad de datos que tiene la lista*/
            Console.WriteLine($"Cantidad de registros: {listaPersonas.Count}");
        }
    }
}
