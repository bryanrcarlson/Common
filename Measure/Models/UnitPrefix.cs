using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Common.Measure.Models
{
    public class UnitPrefix
    {
        private readonly string prefix;
        private readonly double factor;

        public string Prefix { get { return prefix; } }
        public double Factor { get { return factor; } }

        public UnitPrefix(string prefix, double factor)
        {
            this.prefix = prefix;
            this.factor = factor;
        }
    }
}
