using System;


namespace AutoGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Weapon bronzesword = new Weapon();
            Gladiator gladiator = new Gladiator("Maximus");
            gladiator.EquipTwoHanded(bronzesword);
            Console.WriteLine(gladiator.TotalAttack);

        }
    }
}
