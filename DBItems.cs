using AutoGladiators.Interfaces;

namespace AutoGladiators
{
    public class DbItems : IItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public bool IsEquipped { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public int Attack { get; set; }
        public float AttackSpeed { get; set; }
        public int Defence { get; set; }
    }
}