using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    class Gladiator : IGladiator
    {
        //attributes and abilities of a gladiator
        public string Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int BaseHealth { get; set; }

        public int BaseStrength { get; set; }

        public int BaseDefence { get; set; }

        public int BaseAgility { get; set; }

        public object armour { get; set; }
        public object Armour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object leftHand { get; set; }
        public object rightHand { get; set; }
        public int TotalAttack { get; set; }
        public int TotalDefence { get; set; }
        public int TotalAgility { get; set; }

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
    }
}
