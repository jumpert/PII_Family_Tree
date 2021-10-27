using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class VisitanteByEdad : Visitor
    {
        public override void Visit(Node node)
        {
            // Se crea un nuevo nodo comparador, con parametros "" y 0, en
            // nombre y edad respectivamente para tener un valor de comparación
            Node nodoMayor = new Node(new ("", 0));
            foreach (Node _nodo in node.Childrens)
            {
                foreach (Node nodo in _nodo.Childrens)
                {
                    // Se comparan las edades y en caso de ser mayor se guarda 
                    // en la variable nodoMayor
                    if (nodo.Person.Edad > nodoMayor.Person.Edad)
                    {
                        nodoMayor = nodo;
                    }
                }
            }
            // Imprime los datos de la persona, con una pequeña referencia.
            Console.WriteLine($"{nodoMayor.Person.Nombre} tiene {nodoMayor.Person.Edad} años y es el mayor.");
            
        }
    }
}
