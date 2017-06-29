using Nsar.Common.Measure.Models;
using System;
using System.Collections.Generic;
using System.Text;
//using Afk.Measure;

namespace Nsar.Common.Measure
{
    /// <summary>
    /// INCOMPLETE
    /// Style guide: http://physics.nist.gov/cuu/Units/checklist.html
    /// Conversion tool, meaning, etc: http://cdsarc.u-strasbg.fr/cgi-bin/Unit?W/m2
    /// </summary>
    public class PhysicalQuantityConverter
    {
        private readonly List<Unit> units;


        public PhysicalQuantityConverter()
        {
            this.units = generateUnits();
        }

        public PhysicalQuantity Convert(PhysicalQuantity physicalQuantity)
        {
            // TODO: Aaarrggg, so horrible, my EYESSS!  Implement something non-hacky you plebeian
            PhysicalQuantity pq;

            switch(physicalQuantity.Unit)
            {
                case "TS":
                case "RN":
                case "C":
                case "m/s":
                case "%":
                case "V":
                    pq = physicalQuantity;
                    break;
                case "degrees":
                    pq = new PhysicalQuantity(physicalQuantity.Value, "deg", physicalQuantity.Precision);
                    break;
                case "mm":
                    pq = new PhysicalQuantity(physicalQuantity.Value / 1000, "m", physicalQuantity.Precision);
                    break;
                case "kpa":
                case "kPa":
                    pq = new PhysicalQuantity(physicalQuantity.Value * 1000, "Pa", physicalQuantity.Precision);
                    break;
                case "umol/(s m^2)":
                    pq = new PhysicalQuantity(physicalQuantity.Value / 1000000, "mol/(m^2 s)", physicalQuantity.Precision);
                    break;
                case "W/m^2":
                    pq = new PhysicalQuantity(physicalQuantity.Value, "kg/s^3", physicalQuantity.Precision);
                    break;
                default:
                    throw new Exception("Error parsing units");
            }

            // search symbols for standard (and derived?) symbols
            // if found standard/derived symbol then check for standard prefix
            // if standard prefix, convert using multiplier
            return pq;
        }
        private List<Unit> generateUnits()
        {
            // TODO: HACK, incomplete, probably should rewrite or at least read from a json file

            List<Unit> units = new List<Unit>();

            // SI units
            units.Add(new Unit(
                "meter",
                "meter",
                new List<string>()
                { "m" },
                1, 0));
            units.Add(new Unit(
                "kilogram",
                "kilogram",
                new List<string>()
                { "kg" },
                1, 0));
            units.Add(new Unit(
                "second",
                "second",
                new List<string>()
                { "s" },
                1, 0));
            units.Add(new Unit(
                "ampere",
                "ampere",
                new List<string>()
                { "A" },
                1, 0));
            units.Add(new Unit(
                "kelvin",
                "kelvin",
                new List<string>()
                { "K" },
                1, 0));
            units.Add(new Unit(
                "mole",
                "mole",
                new List<string>()
                { "mol" },
                1, 0));
            units.Add(new Unit(
                "radian",
                "radian",
                new List<string>()
                { "rad" },
                1, 0));
            units.Add(new Unit(
                "steradian",
                "steradian",
                new List<string>()
                { "sr" },
                1, 0));
            units.Add(new Unit(
                "candela",
                "candela",
                new List<string>()
                { "cd" },
                1, 0));

            // SI derived units
            units.Add(new Unit(
                "pascal",
                "pascal",
                new List<string>()
                { "kg m^-1 s^-2", "Pa", "pa", "N/m2", "N/m^2"},
                1, 0));
            units.Add(new Unit(
                "velocity",
                "velocity",
                new List<string>()
                { "m s^-1", "m/s"  },
                1, 0));

            // non-si units
            units.Add(new Unit(
                "kilopascal",
                "pascal",
                new List<string>()
                { "kPa", "kpa" },
                1000,0));

            units.Add(new Unit(
                "millimeter",
                "m",
                new List<string>()
                { "mm" },
                0.001,0));

            units.Add(new Unit(
                "degree Celcius",
                "kelvin",
                new List<string>()
                { "C" },
                0,273.15));

            

            return units;
        }
        private List<UnitPrefix> generateUnitPrefixes()
        {
            List<UnitPrefix> prefixes = new List<UnitPrefix>();

            prefixes.Add(new UnitPrefix("m", 0.001));

            return prefixes;
        }
    }
}
