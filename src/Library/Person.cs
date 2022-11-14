using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }
    }
}