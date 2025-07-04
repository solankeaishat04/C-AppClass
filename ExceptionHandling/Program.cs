namespace ExceptionHandling
{
    internal class Program
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new MyOwnException("Must be older than 18");
            }
        }


        static void Main(string[] args)
        {
            // MyOwnException ex  = new MyOwnException("Cannot divide by zero");



            try
            {
                validate(13);
            }
            catch(MyOwnException e) 
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Rest of the App");



            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
              
            }
            finally
            {
                Console.WriteLine("This is the block of code after the catch block");
            }
            Console.WriteLine("Rest of the application");

        }
    }
}
