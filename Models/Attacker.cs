namespace DamageCalcLibrary.Models
{
    public class Attacker
    {
        public int Level { get; set; }
        public int Attack { get; set; }
        public bool Crit { get; set; }
        public double CritDamage { get; set; }
        public double BreakEffect { get; set; }
        public double DamageBoost { get; set; }
        public double ElementalDmgBoost { get; set; }

    }
}