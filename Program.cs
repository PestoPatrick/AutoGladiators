using System;


namespace AutoGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gladiator gladiator = new Gladiator("Maximus");
            Console.WriteLine(gladiator.ToString());

        }
    }
}
