using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Polymophism
    {
        //public void print(int i)
        // {
        //     Console.WriteLine("Printing int: {0}", i);
        // }
        //public void print(double f)
        // {
        //     Console.WriteLine("Printing float: {0}", f);
        // }
        //public void print(string s)
        // {
        //     Console.WriteLine("Printing string: {0}", s);
        // }


        public double lenght;
        public double breadth;
        public double height;

        public Polymophism(double height, double breadth, double lenght)
        {
            this.height = height;
            this.breadth = breadth;
            this.lenght = lenght;
        }

        public double volume ()
        {
            return lenght * breadth * height;
        }

        public static Polymophism operator +(Polymophism b1,Polymophism b2)
        {
            return new Polymophism(b1.lenght + b2.lenght, b1.breadth + b2.breadth, b1.height + b2.height);
        }

        public void Display()
        {
            Console.WriteLine("Dimensions: {0} x {1} x {2}", lenght, breadth, height);
        }
    } 
}
