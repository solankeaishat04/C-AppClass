namespace Collections
{
    internal class Program
    {
        delegate int square(int x);
        static void Main(string[] args)
        {
            //List
          //List<string> fruit = new List<string>();
          //  fruit.Add("Banana");
          //  fruit.Add("Grapes");
          //  fruit.Add("Apples");
          //  foreach (var item in fruit)
          //  {
          //      Console.WriteLine(item);   
          //  }

          //  List<int> Number = new List<int>();

            //Hashset
            HashSet<string> names = new HashSet<string> {"Jide", "Jide", "Daniel", "David", "Aishat", "Eniola", "Daniel" };
            foreach (var item in names)
            {
              //  Console.WriteLine(item);
            }

            //SortedSet
            SortedSet<string> names1 = new SortedSet<string> {"Grace", "Zack", "Daniel", "Adam"};
            foreach (var item in names1)
            {
                //Console.WriteLine(item);
            }


            Stack<int> numbers = new Stack<int>();
            numbers.Push(20);
            numbers.Push(30);
            numbers.Push(40);
            numbers.Push(50);
            foreach (var item in numbers)
            {
               // Console.WriteLine(item);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Thrid");
            foreach (var item in queue)
            {
                //Console.WriteLine(item);
            }

            var names2 = new LinkedList<string>();
            names2.AddLast("James");
            names2.AddLast("Great");
            names2.AddLast("Kehinde");

            LinkedListNode<string> node = names2.Find("Great");
            names2.AddBefore(node, "Aishat");
            names2.AddAfter(node, "Daniel");

            foreach (var item in names2)
            {
               // Console.WriteLine(item);
            }


            Dictionary<int, string>  KVpairs = new Dictionary<int, string>();
            KVpairs.Add(1, "Jide");
            KVpairs.Add(2, "Aishat");
            KVpairs.Add(3, "Enny");
            foreach (KeyValuePair<int, string> item in KVpairs)
            {
                //Console.WriteLine($"{item.Key} {item.Value}");
            }


            //GenericExamples<int> genNum = new GenericExamples<int>(1234);
            //GenericExamples<string> genString = new GenericExamples<string>("This is a generic class");
            //GenericExamples<char> genLetter = new GenericExamples<char>('A');

            square getsquare = x => x * x;
            int num = 3;
            int s = getsquare(num);
            //Console.WriteLine($"The square of {num} is {s}");


            List<Student> students = new List<Student> {
            new Student { Id = 1, Name = "Bob", Age = 17 },
            new Student { Id = 2, Name = "Grace", Age = 19 },
            new Student { Id = 3, Name = "Kehinde", Age = 20 }};

            var names7 = students.Where(s => s.Age > 18).Select(s => s.Name).ToList();
            Console.WriteLine("Student older than 18");

            foreach (var item in names7)
            {
                Console.WriteLine(item);
            }
        }
    }
}
