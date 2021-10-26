using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Persona person;

        public List<Node> Childrens = new List<Node>();
    

        public Persona Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.Childrens.AsReadOnly();
            }
        }

        public Node(Persona person)
        {
            this.person = person;
            
        }

        public void AddChildren(Node n)
        {
            this.Childrens.Add(n);
            
        }
        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
        
    }
}
