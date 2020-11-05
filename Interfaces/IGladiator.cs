namespace AutoGladiators.Interfaces
{
    interface IGladiator
    {
        string Id { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        int Energy { get; set; }
        int Experience { get; set; }
        int BaseHealth { get; set; }
        int TotalHealth { get; set; }

        int BaseStrength { get; set; }

        int BaseDefence { get; set; }

        float BaseAgility { get; set; }

        int TotalAttack { get; set; }

        int TotalDefence { get; set; }

        float TotalAgility { get; set; }

        DbItems Armour { get; set; }

        DbItems LeftHand { get; set; }

        DbItems RightHand { get; set; }

        DbItems TwoHanded { get; set; }

        void Attack(Gladiator enemy);

        void Dodge();

        void Defend();

        void EquipLeft(DbItems weapon);

        void EquipRight(DbItems weapon);

        void EquipTwoHanded(DbItems weapon);

        void EquipArmour(DbItems armour);
    }
}
