using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    class Gladiator : IGladiator
    {
        //attributes and abilities of a gladiator
        public string Id { get; set; }
        public int Level { get; set; }
        public int Energy { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int BaseHealth { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDefence { get; set; }
        public int BaseAgility { get; set; }
        public Armour Armour { get; set; }
        public Weapon LeftHand { get; set; }
        public Weapon RightHand { get; set; }
        public Weapon TwoHanded { get; set; }
        public int TotalAttack { get; set; }
        public int TotalDefence { get; set; }
        public int TotalAgility { get; set; }

        public Gladiator(string name)
        {
            this.Name = name;
            this.BaseStrength = 5;
            this.BaseDefence = 5;
            this.BaseAgility = 5;
            this.TotalAttack = BaseStrength;
        }
        public void Attack(Gladiator enemy)
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

        public void EquipLeft(Weapon weapon)
        {
            if (TwoHanded != null)
            {
                TwoHanded = null;
                TwoHanded.IsEquipped = false;
            }
            LeftHand = weapon;
            weapon.IsEquipped = true;
            TotalAttack += weapon.Attack;
        }

        public void EquipRight(Weapon weapon)
        {
            if (this.TwoHanded != null)
            {
                this.TwoHanded = null;
                
                this.TwoHanded.IsEquipped = false;
            }
            this.RightHand = weapon;
            weapon.IsEquipped = true;
            this.TotalAttack += weapon.Attack;
        
            
        }

        public void EquipTwoHanded(Weapon weapon)
        {
            // set the weapons to unequipped maybe not needed
            //Decrease total attack by the attack of the weapon
            if (this.LeftHand != null)
            {
                this.LeftHand.IsEquipped = false;
                this.TotalAttack -= this.LeftHand.Attack;
            }
            else if (RightHand != null)
            {
                this.RightHand.IsEquipped = false;
                this.TotalAttack -= this.RightHand.Attack;
            }
            //empty the left and right hands
            this.LeftHand = null;
            this.RightHand = null;
            //equip the two handed weapon
            this.TwoHanded = weapon;
            //set weapon to equipped
            weapon.IsEquipped = true;
            // increase total attack by the attack of the weapon
            this.TotalAttack += weapon.Attack;
        }

        public void EquipArmour(Armour armour)
        {
            this.Armour = armour;
            this.TotalDefence += armour.Defence;
        }

    }
}
