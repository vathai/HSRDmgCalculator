using DamageCalcLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalcLibrary
{
    internal class Damage
    {
        public int BaseDamage(Attacker attacker, Skill mod)
        {
            return mod.Multiplier / 100 * attacker.Attack;
        }
        public double DmgBoost(Attacker attacker)
        {
            return 1 + attacker.ElementalDmgBoost / 100 + attacker.DamageBoost;
        }
        public double DefMultiplier(Attacker attacker, Target target)
        {
            return (attacker.Level + 20) / (target.Level + 20) * (1 - target.DefReduction + target.Level + 20);
        }

        public double Toughness(Target target) {
            if (target.Broken) return 1;
            else return 0.9;
        }
        public int StandardDmg(Attacker attacker, Skill mod, Target target)
        {
            if (attacker.Crit)
            {
                return (int)(BaseDamage(attacker, mod) * attacker.CritDamage * 
                    DmgBoost(attacker) * DefMultiplier(attacker, target) * Toughness(target));
            }
            else
            {
                return (int)(BaseDamage(attacker, mod) * DmgBoost(attacker) * DefMultiplier(attacker, target) * Toughness(target));
            }
        }
        //Break Damage Formula not released
        //public int BreakDmg(Attacker attacker, Target target)
        //{
        //    return 1;
        //}
    }
}
