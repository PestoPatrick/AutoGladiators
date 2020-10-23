using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    interface IShield : IItem
    {
        int Defence { get; set; }
        float BlockChance { get; set; }
        float Weight { get; set; }
    }
}
