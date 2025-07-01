using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class Child
   {
        public string Name;
        public int age;
        public Dad dad;

        public Child(string name, int age, Dad dad)
        {
            Name = name;
            this.age = age;
            this.dad = dad;
        }



        public void Display()
        {
            Console.WriteLine($"The child's name is {Name}, the surname of the child is {dad.Surname} and the father is {dad.Age} years old");
        }
   }
}
