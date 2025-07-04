namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dad dad = new Dad("Kehide", 70, "Toluwani");
            Child c1 = new Child("David", 20, dad);
            c1.Display();

            Ishape s;
            s = new Rectangle();
            s = new Square();

            s.look();
            s.look();

            //Polymophism
            //Polymophism polymophism = new Polymophism();
            //polymophism.print(5);
            //polymophism.print(222.33);
            //polymophism.print("Hello c#");

            AbstractClass ab;
            // ab.display();

            //Polymophism ph1 = new Polymophism(3.0, 4.0, 5.0);
            //Polymophism ph2 = new Polymophism(2.0, 3.0,4.0);
            //Polymophism ph3;

            //ph3 = ph1 + ph2;
            //Console.WriteLine("This is the first instance of the polymophism class");
            //ph1.Display();
            //Console.WriteLine("This is the second instance of the polymophism class");
            //ph2.Display();
            //Console.WriteLine("This is the resultant class after addition");
            //ph3.Display();


        }
    }
}
