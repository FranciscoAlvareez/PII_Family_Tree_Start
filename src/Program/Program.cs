using System;
using Library;
using static System.Console;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {         
            Node n1 = new Node(1,"Jesabel",77);
            Node n2 = new Node(2,"Juan",52);
            Node n3 = new Node(3,"Diego",28);
            Node n4 = new Node(4,"Jose",24);
            Node n5 = new Node(5,"Francisco",18);
            Node n6 = new Node(6,"Guillermo",33);
            Node n7 = new Node(7,"Paula",42);
            Node n8 = new Node(8,"Valentina",32);
            Node n9 = new Node(9,"Dante",20);
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n5);
            n2.AddChildren(n6);

            n4.AddChildren(n7);
            n4.AddChildren(n8);

            n3.AddChildren(n9);

            VisitorAge TotalAge1 = new VisitorAge();
            TotalAge1.VisitNode(n1);
            WriteLine($"la suma de las edades de todos los integrantes de la familia es: {TotalAge1.Content()}");
            VisitorName LargestName1 = new VisitorName();
            LargestName1.VisitNode(n1);
            WriteLine(LargestName1.Content());
            VisitorSon Son1 = new VisitorSon();
            Son1.VisitNode(n1);
            WriteLine(Son1.Content());
        }
    }
}