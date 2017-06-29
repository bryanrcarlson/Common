using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Common.Measure.Models
{
    public class Unit
    {
        private readonly string name;
        private readonly string nameSI;
        private readonly string abbrivSI;
        private readonly List<string> abbrivs;
        private readonly double toSIMultiplier;
        private readonly double toSIAddend;

        public string Name { get { return name; } }
        public string NameSI { get { return NameSI; } }
        public List<string> Abbrives { get { return abbrivs; } }
        public double ToSIMultiplier { get { return toSIMultiplier; } }
        public double ToSIAddend { get { return toSIAddend; } }

        public Unit(
            string name,
            string nameSI,
            List<string> abbrivs,
            double toSIMultiplier,
            double toSIAddend)
        {
            this.name = name;
            this.nameSI = nameSI;
            this.abbrivs = abbrivs;
            this.toSIMultiplier = toSIMultiplier;
            this.toSIAddend = toSIAddend;
        }

    }
}
