using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class VisitanteByNombre : Visitor
    {
        
        public override void Visit(Node node)
        {
            // Se crea la variable que servirá de comparador.
            Node nodoLargeName = node;
            // Se recorre la lista de nodos hijos
            foreach (Node _nodo in node.Childrens)
            {
                // En el caso que los hubiera se recorre la lista de nodos nietos
                foreach (Node nodo in _nodo.Childrens)
                {
                    // Se compara el largo de los nombres y se asignan a la variable nodoLargeName
                    if (nodo.Person.Nombre.Length > nodoLargeName.Person.Nombre.Length)
                    {
                        nodoLargeName = nodo;
                    }
                }
                if (_nodo.Person.Nombre.Length > nodoLargeName.Person.Nombre.Length)
                    {
                        nodoLargeName = _nodo;
                    }
            }
            // Imprime en consola el nombre de la persona de la familia que tenga el nombre más largo
            Console.WriteLine($"{nodoLargeName.Person.Nombre} tiene el nombre más largo de la familia.");
        }
    }
}
