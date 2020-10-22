using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    interface IGladiator
    {
        string Id { get; set; }
        string Name { get; set; }
        int Energy { get; set; }
        int Experience { get; set; }
        int BaseHealth { get; set; }

        int BaseStrength { get; set; }

        int BaseDefence { get; set; }

        int BaseAgility { get; set; }

        int TotalStrength { get; set; }

        int TotalDefence { get; set; }

        int TotalAgility { get; set; }

        object Armour { get; set; }

        object LeftHand { get; set; }

        object RightHand { get; set; }

        object TwoHanded { get; set; }

        void Attack();

        void Dodge();

        void Defend();

        void EquipLeft(object weapon);

        void EquipRight(object weapon);

        void EquipTwoHanded(object weapon);
    }
}
