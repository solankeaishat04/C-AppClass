using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AppClass
{
    internal class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }


          

        //public int Id;
        //public string Name;
        //public float salary;
        //public static decimal rateOfIntrest = 20.4m;


        //public Employee(int Id, string Name, float salary)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.salary = salary;
        //}




        //public Employee(int I, string n, float s)
        //{
        //        Id   = I;
        //         Name = n;
        //    salary = s;
        //}


        //public void display()
        //{
        //    Console.WriteLine($"The Id is {Id}, the name is {Name} salary is {salary} {rateOfIntrest}");
        //}
    }


    public class Account
    {
        public int AcctNo;
        public string AcctName;
        public static int count = 0;


        public Account(int AcctNo, string AcctName)
        {
            this.AcctNo = AcctNo;
            this.AcctName = AcctName;
            count++;
        }

        public void display()
        {
            Console.WriteLine($"The account Number is {AcctNo} and the name is {AcctName}");
        }
    }
}
