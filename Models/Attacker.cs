namespace DamageCalcLibrary.Models
{
    public class Attacker
    {
        public int Id { get; set; }
        public string? CharName { get; set; }
        public int CharLevel { get; set; }
        public int Attack { get; set; }
        public bool Crit { get; set; }
        public double CritDamage { get; set; }
        public double BreakEffect { get; set; }
        public double DamageBoost { get; set; }
        public double ElementalDmgBoost { get; set; }

    }
}