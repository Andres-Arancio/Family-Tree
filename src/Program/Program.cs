using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeNodeVisitor ageNodeVisitor = new AgeNodeVisitor();
            OldestNodeVisitor oldestNodeVisitor = new OldestNodeVisitor();
            LongestNameNodeVisitor longestNameNodeVisitor = new LongestNameNodeVisitor();

            Persona me = new Persona(24,"Andres");
            Persona father = new Persona(53,"Daniel");
            Persona mother = new Persona(54,"Monica");
            Persona grandfather2 = new Persona(79,"Julian");
            Persona grandmother2 = new Persona(74,"Maria");
            Persona grandfather1 = new Persona(82,"Dead");
            Persona grandmother1 = new Persona(81,"Isides");
            Persona greatgrandmother = new Persona(100, "Alejandra");

            Node<Persona> n1 = new Node<Persona>(me);
            Node<Persona> n2 = new Node<Persona>(father);
            Node<Persona> n3 = new Node<Persona>(mother);
            Node<Persona> n4 = new Node<Persona>(grandfather1);
            Node<Persona> n5 = new Node<Persona>(grandmother1);
            Node<Persona> n6 = new Node<Persona>(grandfather2);
            Node<Persona> n7 = new Node<Persona>(grandmother2);
            Node<Persona> n8 = new Node<Persona>(greatgrandmother);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n5.AddChildren(n8);

            // visitar el árbol aquí
            ageNodeVisitor.Visit(n1);

            Console.WriteLine($"Total Age: {ageNodeVisitor.ReturnValue()}");

            oldestNodeVisitor.Visit(n1);

            Console.WriteLine($"Highest Age: {oldestNodeVisitor.ReturnOldest().edad}, Oldest Person: {oldestNodeVisitor.ReturnOldest().nombre}");

            longestNameNodeVisitor.Visit(n1);
            
            Console.WriteLine($"Longest Name: {longestNameNodeVisitor.ReturnLongest().nombre}");
        }
    }
}
