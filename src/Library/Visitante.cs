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
            ContentAge += node.Person.Edad;
            
            foreach (Node _nodo in node.Childrens)
            {
                foreach (Node nodo in _nodo.Childrens)
                {
                    ContentAge += nodo.Person.Edad;
                }
                ContentAge += _nodo.Person.Edad;
            }

            Console.WriteLine(Content);
            
        }
    }
}
