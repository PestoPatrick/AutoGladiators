using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    class Shield : IShield
    {
        public int Defence { get; set; }
        public float BlockChance { get; set; }
        public float Weight { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEquipped { get; set; }
        public string Type { get; set; }
        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
