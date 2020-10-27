using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    class Armour : IArmour
    {
        public bool IsEquipped { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Defence { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public float Weight { get; set; }
    }
}
