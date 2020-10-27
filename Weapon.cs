using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    class Weapon : IWeapon
    {
        public int Attack { get; set; }
        public float AttackSpeed { get; set; }
        public int Level { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEquipped { get; set; }
        public string Type { get; set; }
        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Weapon()
        {
            Id = "9890jhjhjk423hukhgyt8";
            Attack = 3;
            AttackSpeed = 0.8F;
            Level = 1;
            Name = "Bronze Longsword";
            Description = "A bronze longsword for use by the beginner gladiator";
            IsEquipped = false;
            Type = "Bronze";
        }
    }
}
