using System.Runtime.Versioning;

namespace C_AppClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            //int x = 2;
            //char A = 'A';
            //string name = "Bolu";

            //int data = 10 + 5 * 5;           
            //Console.WriteLine( data );



            // Program program = new Program();
            //string message = program.show("Daniel");
            // Console.WriteLine("Hello " + message);

            //int val = 50;
            //Program program = new Program();
            //Console.WriteLine("Before calling the show function " + val);
            //program.show(out val);
            //Console.WriteLine("After calling the show function " + val);


            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[2] = 20;
            //arr[4] = 30;

            //int[] arr = {10,20,30,40,50 };

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //for(int i = 0; i < arr.Length; i++ )
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //int[] arr1 = {1,2,3,4,5};
            //int [] arr2 = {6,7,8,9,10};
            //printArry(arr1);
            //printArry(arr2);


            //int[,] arr = new int[3, 3];
            //arr[0, 1] = 10;
            //arr[1, 2] = 20;
            //arr[2, 0] = 30;

            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[][] arr1 = new int[3][]; 

            //Console.WriteLine("C_AppClass!");
            //int x = 10,
            //    y = 20,
            //    z = 30;

            //string textAge = " -23";
            //int age = Convert.ToInt32(textAge);
            //Console.WriteLine(age);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            //string textBigNumber = "-900000000";
            //long bigNumber = Convert.ToInt64(textBigNumber);
            //Console.WriteLine(bigNumber);
            //Console.WriteLine(long.MaxValue);
            //Console.WriteLine(long.MinValue);


            //double negative = -55.20;
            //Console.WriteLine(negative);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);

            //float precision = 5.000001F;
            //Console.WriteLine(precision);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(float.MinValue);

            //age = 50;

            //string name = "Aba";
            //char letter = 'a';

            //Console.WriteLine("Your name is");
            //Console.WriteLine(letter);

            //bool value = false;
            //bool isMale = false;
            //Console.WriteLine(isMale);

            //string name = "Aba";
            //name += "is programming!";

            //Console.WriteLine(name);
            //
            //int firstNum = 10;
            //int secondNum = 3;
            //Console.WriteLine(firstNum % secondNum);
       

            Program program = new Program();

            Student s1 = new Student();
            //s1.Id = 1;
            //s1.Name = "Aishat";
            //Console.WriteLine(s1.Id);
            //Console.WriteLine(s1.Name);

            //Employee e1 = new Employee(100, "Tolu", 700.22f);
            //e1.display();

            //Employee e2 = new Employee(201, "Kehinde", 850.77f);
            //e2.display();

            //Account acct = new Account(432345678, " Hera Zeus");
            //Account acct1 = new Account(345789876, "Kehinde Devid");
            //Account acct2 = new Account(876543576, "Aishat Jide");
            //Account acct3 = new Account(123454322, "Titi James");
            //acct.display();
            //acct1.display();
            //acct2.display();
            //acct3.display();

            //Console.WriteLine("The total objects are " + Account.count);

         
            //Console.WriteLine( "The value of PI is " + MyMath.pi );
            //Console.WriteLine("The value of cube is " + MyMath.cube(3));

            Rectangle r1 = new Rectangle();
            r1.height = 12;
            r1.width = 17;
            //Console.WriteLine("The area of a rectangle is " + (r1.height * r1.width));

            //int x = (int)Season.winter;
            //int y = (int)Season.Fall;

            //Console.WriteLine("winter {0} " , x);
            //Console.WriteLine("fall {0} ", y);

            //foreach (Days d in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine(d);
            //}

            //Employee emp = new Employee();
            //emp.Name = "Grace Jude";
            //Console.WriteLine("Emplyee's name is " + emp.Name);

            //string greett = "Hello c#";
            //int lenght = greett.Length;
            //Console.WriteLine("the length of the string is " + lenght);

            //string lname, fname; 
            // lname = "Grace";
            // fname = "Titi";

            //char[] letter = { 'H', 'E', 'L', 'L', 'O' };
            //string[] greet =  {
            //"Welcome",
            //"To",
            //"C#",
            //"Class"
            //};

            //string fullname = fname + " " + lname;
            //Console.WriteLine("Full Name: {0}", fullname);


            //string greetings = new string(letter);
            //Console.WriteLine($"Greetings: {greetings}");


            //string message = String.Join(" ", greet);
            //Console.WriteLine("Message: {0}", message);

            //DateTime waiting = new DateTime(2025, 07, 07, 10, 44, 4);
            //string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            //Console.WriteLine("Message: {0}", chat);


            //string s2 = "Looping through a string";
            //string s3 = "Comparing 2 strings";
            //string s4 = "Comparing 2 strings";
            //if (string.Compare(s3 , s4) == 0)
            //{
            //    Console.WriteLine("They are equal");
            //}
            //else
            //{
            //    Console.WriteLine("They are not equal");
            //}

            string str = "To check if they contain";
            if (str.Contains("To"))
            {
                Console.WriteLine("It contains to");   
            }

            //foreach (char ch in s2)
            //{
            //    Console.WriteLine(ch);
            //}


            Console.ReadLine();

        }





        public enum Days
        {
            monday,
            Tueday,
            Wednesday,
            Thurdsday,
            Friday,
            Saturday,
            Sunday
        }

        public enum Season
        {
            summer  ,
            winter,
            spring,
            Fall

        }

        //static void printArry(int[] arr)
        //{
        //    Console.WriteLine("Printing Array Elements");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}


        //public void show (out int val)
        //{
        //    val = 10;
        //    val *= val;
        //    Console.WriteLine("Value inside the show function " + val);
        //}

        //public void show (ref int val)
        //{
        //    val *= val;
        //    Console.WriteLine("Value inside the show function " + val);
        //}

        //public void show (int val)
        //{
        //    val *= val;
        //    Console.WriteLine("Inside the show function " + val);
        //}


        //public void show()
        //{
        //    Console.WriteLine("This is a non parameterlised function");
        //} 

        //public void show(string message)
        //{
        //    Console.WriteLine("Hello " + message);
        //}

        //public string show(string message)
        //{
        //    Console.WriteLine("Inside the show function");
        //    return message;
        //} 


        

       


        
     }



}

