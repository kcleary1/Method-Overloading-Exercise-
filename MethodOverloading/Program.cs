namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Add(3.12M, 4.23M));
            Console.WriteLine(Add(1, 0, false));
            Console.WriteLine(Add(2, 5, true));

               
        }

        public static int Add(int x, int y)
        {
            return (x + y);
        }

        public static decimal Add(decimal x, decimal y)
        {
            return (x + y);

        }

        public static string Add(int x, int y, bool a)
        {
            
            if (a && (x + y) > 1)
            {
                return $"You have {x + y} dollars.";

            }
            else return $"You have {x + y} dollar.";
        }
    }
}
