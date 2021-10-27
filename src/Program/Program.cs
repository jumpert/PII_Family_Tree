using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Node n1 = new Node(new Persona("Ana", 81));
            Node n2 = new Node(new Persona("Bean", 50));
            Node n3 = new Node(new Persona("Carl", 47));
            Node n4 = new Node(new Persona("Delfy", 24));
            Node n5 = new Node(new Persona("Eli", 25));
            Node n6 = new Node(new Persona("Fran", 27));
            Node n7 = new Node(new Persona("Gus", 13));
            Node n8 = new Node(new Persona("Hec", 14));
            

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // Para la implementación de la Parte 3
            Visitor visitor = new Visitante();
            Console.WriteLine("visitante 1: "); 
            n1.Accept(visitor);
            
            // Para la implementación de la Parte 4.1
            Visitor visitorMayor = new VisitanteByEdad();
            Console.WriteLine("Visitante por edad: ");
            n1.Accept(visitorMayor);

            // Para la implementación de la Parte 4.1
            Visitor visitorNombre = new VisitanteByNombre();
            Console.WriteLine("Visitante por Nombre: ");
            n1.Accept(visitorNombre);
        }
    }
}
