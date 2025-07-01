using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class AbstractClass
    {
        private string name;
        private string type;

        public AbstractClass(string type, string name)
        {
            this.type = type;
            this.name = name;
        }

       public void display()
       {
            Console.WriteLine("This is an abstract class");
       }

    }
}
