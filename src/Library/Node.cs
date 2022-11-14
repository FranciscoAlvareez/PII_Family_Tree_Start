using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        public Person Person{get;}
        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, string name, int age)
        {
            this.number = number;
            this.Person = new Person(name, age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Aceppt (Visitor visitor){
            visitor.VisitNode(this);
        }
    }
}
