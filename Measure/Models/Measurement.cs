using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Common.Measure.Models
{
    public class Measurement
    {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public PhysicalQuantity PhysicalQuantity { get; set; }
    }
}
