namespace BDServer.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int AttackModifier { get; set; }
        public int AttackPerRound { get; set; }
        public int DamageDiceCount { get; set; }
        public int DamageDiceType { get; set; }
        public int WeaponModifier { get; set; }
    }
}