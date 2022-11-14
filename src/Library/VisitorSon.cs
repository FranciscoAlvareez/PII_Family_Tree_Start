using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorSon:Visitor
    {
        public override string Content()
        {
            return FirstBorn.name;
        }
    
        public Person FirstBorn{get;set;}
        public override void Visit(Person person)
        {
            if (FirstBorn==null)
            {
                FirstBorn=person;
            }
            else 
            {
                if (person.age>FirstBorn.age)
                {   
                    FirstBorn=person;
                }
            
            }
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