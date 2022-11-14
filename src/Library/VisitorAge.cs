using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorAge:Visitor
    {
        public int TotalAge{get;set;}  
        public VisitorAge()
        {
            this.TotalAge= 0;
        }
        public override string Content()
        {
          return TotalAge.ToString();
        }
    
        public override void Visit(Person person)
        {
            TotalAge+=person.age;
        }
        public override void VisitNode(Node node)
        {
            foreach (Node Child in node.Children)
            {
                Child.Aceppt(this);
                this.Visit(Child.Person);
            }
        }
    }
}