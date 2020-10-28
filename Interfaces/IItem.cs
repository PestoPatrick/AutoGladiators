namespace AutoGladiators.Interfaces
{
    interface IItem
    {
        string Id { get; set; }
        string Name { get; set; }
        int Level { get; set; }
        string Description { get; set; }
        bool IsEquipped { get; set; }
        string Type { get; set; }
        int Value { get; set; }
        int Attack { get; set; }
        float AttackSpeed { get; set; }
        int Defence { get; set; }

        

    }
}
