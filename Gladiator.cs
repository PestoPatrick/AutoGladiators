using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    class Gladiator : IGladiator
    {
        //attributes and abilities of a gladiator
        public string Id { get; set; }
        public int Energy { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int BaseHealth { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDefence { get; set; }
        public int BaseAgility { get; set; }
        public object Armour { get; set; }
        public object LeftHand { get; set; }
        public object RightHand { get; set; }
        public object TwoHanded { get; set; }
        public int TotalStrength { get; set; }
        public int TotalDefence { get; set; }
        public int TotalAgility { get; set; }

        public Gladiator(string name)
        {
            this.Name = name;
            this.BaseStrength = 5;
            this.BaseDefence = 5;
            this.BaseAgility = 5;
        }
        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }

        public void Dodge()
        {
            throw new NotImplementedException();
        }

        public void EquipLeft(object weapon)
        {
            this.TwoHanded = null;
            this.LeftHand = weapon;
        }

        public void EquipRight(object weapon)
        {
            this.TwoHanded = null;
            this.RightHand = weapon;
        }

        public void EquipTwoHanded(object weapon)
        {
            this.LeftHand = null;
            this.RightHand = null;
            this.TwoHanded = weapon;
        }

        public void EquipArmour(object armour)
        {
            this.Armour = armour;
        }

    }
}
