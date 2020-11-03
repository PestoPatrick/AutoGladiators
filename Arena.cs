using System;
using System.Security.Cryptography;
using AutoGladiators.Interfaces;

namespace AutoGladiators
{
    public class Arena: IRoom
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public static string ArenaBattle(Gladiator gladiator1) {
            
            Gladiator gladiator2 = new Gladiator("Alexios");

            string resultString1 = $"Congratulations {gladiator1.Name} you win! You gained {gladiator1.GetExperience()}";
            string resultString2 = $"Congratulations {gladiator2.Name} you win! You gained {gladiator2.GetExperience()}";

            while (gladiator1.TotalHealth != 0 && gladiator2.TotalHealth != 0)
            {
                int attackChance = RandomNumberGenerator.GetInt32(1,100);
                if(attackChance <= 50)
                {
                    int dmgG2 = gladiator1.TotalAttack - gladiator2.TotalDefence; 
                    gladiator2.TotalHealth -= dmgG2;
                }
                else
                {
                    int dmgG1 = gladiator2.TotalAttack - gladiator1.TotalDefence;
                    gladiator1.TotalHealth -= dmgG1;
                }
            }
            if (gladiator1.TotalHealth > 0)
            {
                // Console.WriteLine(resultString1);
                return resultString1;
            }
            else if (gladiator2.TotalHealth > 0)
            { 
                // Console.WriteLine(resultString2);
                return resultString2;
            }
            else
            {
                string defaultstring = "Both warriors are dead";
                Console.WriteLine(defaultstring);
                return defaultstring;
            }
        }
    }
}