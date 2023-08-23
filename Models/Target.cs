using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalcLibrary.Models
{
    internal class Target
    {
        public string Name { get; set; } = "Target";
        public int Level { get; set; }
        public double DefReduction { get; set; }
        public int Defense { get; set; }
        public int ElementalRes { get; set; }
        public bool Broken { get; set; }

    }
}
