using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    interface IGladiator
    {
        string Id { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        int Energy { get; set; }
        int Experience { get; set; }
        int BaseHealth { get; set; }

        int BaseStrength { get; set; }

        int BaseDefence { get; set; }

        int BaseAgility { get; set; }

        int TotalAttack { get; set; }

        int TotalDefence { get; set; }

        int TotalAgility { get; set; }

        Armour Armour { get; set; }

        Weapon LeftHand { get; set; }

        Weapon RightHand { get; set; }

        Weapon TwoHanded { get; set; }

        void Attack(Gladiator enemy);

        void Dodge();

        void Defend();

        void EquipLeft(Weapon weapon);

        void EquipRight(Weapon weapon);

        void EquipTwoHanded(Weapon weapon);

        void EquipArmour(Armour armour);
    }
}
