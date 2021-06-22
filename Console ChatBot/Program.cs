using System;

namespace Console_ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What's your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", Nice To Meet You!");

            Console.WriteLine("What's your Favourite Food?");
            string favFood = Console.ReadLine();
            if (favFood == "pizza")
            {
                Console.WriteLine("I Like Pizza Too!");
            }
            Console.WriteLine("What's Your Favourite Color?");
            string favColor = Console.ReadLine();
            Console.WriteLine(favColor + " Is My Favourite Color Too!");
            Console.WriteLine("Where Are You From?");
            string place = Console.ReadLine();
            Console.WriteLine("What Are Your Hobbies?");
            string hobby = Console.ReadLine();
            if (hobby == "coding")
            {
                Console.WriteLine("Wow, You're Right, Coding Is Great!");
            }
            Console.WriteLine("What's Your Favourite Video Game?");
            string favGame = Console.ReadLine();
            if (favGame == "Minecraft")

            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
    }
}
