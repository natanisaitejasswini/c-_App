using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int favoriteNum = 42;
            Console.WriteLine("You can even directly print numbers such as the one below...");
            Console.WriteLine(favoriteNum);
            Console.WriteLine("Hello World!");
            Console.WriteLine("***************");
            //Making use of tokens makes injection of variables into strings quite simple
            Console.WriteLine("The {0} cow, jumped over the {1}, {2} times!", "brown", "Moon", 7);
            //Results in "The brown cow, jumped over the Moon, 7 times!"
            //We can also make use of string concatenation though, if preferred
            string name = "David";
            Console.WriteLine(10 + " Chickens attacked " + name);
            Console.WriteLine("***************");
            string interpol = $"The answer to 2 + 7 is {2+7}";
            Console.WriteLine(interpol);
        }
    }
}
