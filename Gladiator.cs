using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using AutoGladiators.Interfaces;

namespace AutoGladiators
{
    
    public class Gladiator : IGladiator
    {
        public int GetExperience()
        {
            return RandomNumberGenerator.GetInt32(1,11);
        }

        //attributes and abilities of a gladiator
        public string Id { get; set; }
        public int Level { get; set; }
        public int Energy { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int BaseHealth { get; set; }
        public int TotalHealth { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDefence { get; set; }
        public float BaseAgility { get; set; }
        public int TotalAttack { get; set; }
        public float TotalAgility { get; set; }
        public int TotalDefence { get; set; }
        public int Money { get; set; }
        public Armour Armour { get; set; }
        public Weapon LeftHand { get; set; }
        public Weapon RightHand { get; set; }
        public Weapon TwoHanded { get; set; }
        public List<object> Inventory { get; set; }

        public Gladiator(string name)
        {
            this.Name = name;
            this.Armour = new Armour();
            this.BaseHealth = 10;
            this.BaseStrength = 5;
            this.BaseDefence = 5;
            this.BaseAgility = 5;
            this.TotalHealth = this.Armour.Defence + this.BaseHealth;
            this.TotalAttack = BaseStrength;
            this.Inventory = new List<object>();
            this.LeftHand = null;
            this.RightHand = null;
            this.TwoHanded = null;
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
            if (weapon.Type != "OneHanded") return;
            if (TwoHanded != null)
            {
                TwoHanded.IsEquipped = false;
                TwoHanded = null;
            }
            LeftHand = weapon;
            weapon.IsEquipped = true;
            TotalAttack += weapon.Attack;
        }

        public void EquipRight(Weapon weapon)
        {
            if (weapon.Type != "OneHanded") return;
            if (this.TwoHanded != null)
            {
                this.TwoHanded.IsEquipped = false;
                this.TwoHanded = null;
            }
            this.RightHand = weapon;
            weapon.IsEquipped = true;
            this.TotalAttack += weapon.Attack;
        
            
        }

        public void EquipTwoHanded(Weapon weapon)
        {
            // set the weapons to unequipped maybe not needed
            //Decrease total attack by the attack of the weapon
            if (weapon.Type != "TwoHanded") return;
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

        public void UnEquipArmour(Armour armour)
        {
            armour.IsEquipped = false;
            TotalDefence -= armour.Defence;
            TotalAgility -= armour.AttackSpeed;
        }

        public void UnEquipLeftWeapon(Weapon weapon)
        {
            if (LeftHand == null) return;
            weapon.IsEquipped = false;
            TotalAttack -= weapon.Attack;
            LeftHand = null;
        }
        
        public void UnEquipRightWeapon(Weapon weapon)
        {
            
            if (RightHand == null) return;
            weapon.IsEquipped = false;
            TotalAttack -= weapon.Attack;
            RightHand = null;
        }
        public void UnEquipTwoHandedWeapon(Weapon weapon)
        {
            if (TwoHanded == null) return;
            weapon.IsEquipped = false;
            TotalAttack -= weapon.Attack;
            TwoHanded = null;
        }
    }
}
