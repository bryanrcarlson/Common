using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Common.Measure.Models
{
    public class PhysicalQuantity
    {
        private readonly double value;
        private readonly string unit;

        public double Value { get { return value; } }
        public string Unit { get { return unit; } }

        public PhysicalQuantity(
            double value,
            string unit)
        {
            this.value = value;
            this.unit = unit;
        }
    }
}
