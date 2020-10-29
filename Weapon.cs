using System;
using System.Collections.Generic;
using System.Text;
using AutoGladiators.Interfaces;

namespace AutoGladiators
{
    class Weapon : IItem
    {
        public int Attack { get; set; }
        public float AttackSpeed { get; set; }
        public int Level { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEquipped { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public int Defence { get; set; }

        public Weapon()
        {
            Id = "1";
            Attack = 3;
            AttackSpeed = 0.8F;
            Defence = 0;
            Level = 1;
            Name = "Bronze Longsword";
            Description = "A bronze longsword for use by the beginner gladiator";
            IsEquipped = false;
            Type = "OneHanded";
            Value = 25;
        }
    }
}
