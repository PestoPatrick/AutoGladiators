using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    interface IWeapon : IItem
    {
        int Attack { get; set; }
        float AttackSpeed { get; set; }
        int Level { get; set; }
    }
}
