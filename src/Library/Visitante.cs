using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class Visitante : Visitor
    {
        public override void Visit(Node node)
        {
            // Suma la edad del propio nodo
            ContentAge += node.Person.Edad;
            // Recorre la lista de nodos hijos y nietos para sumar la edad de los mismos

            foreach (Node _nodo in node.Childrens)
            {
                foreach (Node nodo in _nodo.Childrens)
                {
                    ContentAge += nodo.Person.Edad;
                }
                ContentAge += _nodo.Person.Edad;
            }
            // Imprime la suma de edad de la familia.
            Console.WriteLine(Content);
        }
    }
}
