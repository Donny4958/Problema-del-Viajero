using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal.Model
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public int X{ get; set; }
        public int Y{ get; set; }
        public List<(Nodo Destino, int Peso)> Adyacentes { get; set; }

        public Nodo(string nombre,int x,int y)
        {
            Nombre = nombre;
            X = x;
            Y = y;
            Adyacentes = new List<(Nodo, int)>();
        }

        public void AgregarAdyacente(Nodo destino, int peso)
        {
            Adyacentes.Add((destino, peso));
        }
        public void EliminarAdyacente(Nodo destino)
        {
            Adyacentes.RemoveAll(a => a.Destino == destino);
        }
    }


    public class Grafo
    {
        private Dictionary<string, Nodo> nodos;

        public Grafo()
        {
            nodos = new Dictionary<string, Nodo>();
        }
        
        public void AgregarNodo(string nombre,int x,int y)
        {
            if (!nodos.ContainsKey(nombre))
            {
                nodos[nombre] = new Nodo(nombre,x,y);
            }
        }
        public bool Existe(string nombre) {
            if (nodos.ContainsKey(nombre))
            {
                return true;
            }
            return false;
        }
        public bool Contiene(string origen, string destino)
        {
             if (nodos.ContainsKey(origen))
    {
        // Verificar si existe una arista desde el nodo origen al nodo destino
        return nodos[origen].Adyacentes.Any(a => a.Destino.Nombre == destino);
    }
    return false;
        }
        public void AgregarArista(string origen, string destino, int peso)
        {
            if(nodos.ContainsKey(origen) && nodos.ContainsKey(destino))
            {
                nodos[origen].AgregarAdyacente(nodos[destino], peso);

            }
            


        }

        public Dictionary<string, Nodo> ObtenerNodos()
        {
            return nodos;
        }

        public string ObtenerRepresentacion()
        {
            var representacion = new List<string>();
            foreach (var nodo in nodos)
            {
                string conexiones = string.Join(", ", nodo.Value.Adyacentes.Select(a => $"({a.Destino.Nombre}, Peso: {a.Peso})"));
                representacion.Add($"\n{nodo.Key}: {conexiones}");
            }
            return string.Join(Environment.NewLine, representacion);
        }
        public bool EliminarNodo(string nombre)
        {
            if (!nodos.ContainsKey(nombre))
            {
                return false; // Si el nodo no existe, retorna false
            }

            // Eliminar las aristas que apuntan al nodo
            foreach (var nodo in nodos.Values)
            {
                nodo.Adyacentes.RemoveAll(ad => ad.Destino.Nombre == nombre);
            }

            // Eliminar el nodo del grafo
            nodos.Remove(nombre);
            return true; // Si se elimina correctamente, retorna true
        }
        public void ImprimirGrafo()
        {
            foreach (var nodo in nodos.Values)
            {
                Console.Write($"Nodo {nodo.Nombre}: ");
                foreach (var (destino, peso) in nodo.Adyacentes)
                {
                    Console.Write($"({destino.Nombre}, Peso: {peso}) ");
                }
                Console.WriteLine();
            }
        }
        public int ContarNodos()
        {
            return nodos.Count;
        }
        public void EliminarArista(string origen, string destino)
        {            
            if (nodos.ContainsKey(origen) && nodos.ContainsKey(destino))
            {
                // Eliminar la arista en el nodo de origen que apunta al nodo de destino
                nodos[origen].EliminarAdyacente(nodos[destino]);
            }
            else
            {
                Console.WriteLine("Uno o ambos nodos no existen en el grafo.");
            }
        }
        public bool CambiarNombreNodo(string nombreActual, string nuevoNombre)
        {
            // Verificar si el nodo actual existe
            if (!nodos.ContainsKey(nombreActual))
            {
                return false; // El nodo no existe
            }

            // Verificar si el nuevo nombre ya está en uso
            if (nodos.ContainsKey(nuevoNombre))
            {
                return false; // El nuevo nombre ya está en uso
            }

            // Obtener el nodo que se quiere renombrar
            Nodo nodo = nodos[nombreActual];

            // Eliminar el nodo con el nombre actual
            nodos.Remove(nombreActual);

            // Cambiar el nombre del nodo
            nodo.Nombre = nuevoNombre;

            // Reinsertar el nodo con el nuevo nombre
            nodos[nuevoNombre] = nodo;

            // Actualizar todas las aristas que apuntan a este nodo para usar el nuevo nombre
            foreach (var otherNodo in nodos.Values)
            {
                foreach (var (destino, peso) in otherNodo.Adyacentes)
                {
                    if (destino.Nombre == nombreActual)
                    {
                        destino.Nombre = nuevoNombre;
                    }
                }
            }

            return true; // El cambio fue exitoso
        }

    }

}
