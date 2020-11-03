using System;
using System.Collections.Generic;
using System.Text;
using AutoGladiators.Interfaces;

namespace AutoGladiators
{
    public class Armour : IItem
    {
        public bool IsEquipped { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public float AttackSpeed { get; set; }
        public int Defence { get; set; }
        
        public string Type { get; set; }
        public int Value { get; set; }
        
    }
}
