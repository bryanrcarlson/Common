using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Common.UnitOfMeasure
{
    public interface IPhenomenon
    {
        string Name { get; }
        string Abbriviation { get; }
        string Metadata { get; }
    }

    public class Phenomenon : IPhenomenon
    {
        private readonly string name;
        private readonly string abbriviation;
        private readonly string metadata;

        public virtual string Name { get { return this.name; } }
        public virtual string Abbriviation { get { return this.abbriviation; } }
        public virtual string Metadata { get { return this.metadata; } }

        public Phenomenon(string name, string abbriviation, string metadata)
        {
            this.name = name;
            this.abbriviation = abbriviation;
            this.metadata = metadata;
        }
    }

    //TODO: Use some sort of standard envrionmental naming scheme here

    public class AirTemperature : Phenomenon
    {
        public AirTemperature(string metadata)
            : base("Air Temperature", "", metadata) { }
    }

    public class RelativeHumididty : Phenomenon
    {
        public RelativeHumididty(string metadata) : base("Relative Humidity", "", metadata) { }
    }

    public class WindSpeed : Phenomenon
    {
        public WindSpeed(string metadata) : base("Wind Speed", "", metadata) { }
    }

    public class WindDirection : Phenomenon
    {
        public WindDirection(string metadata) : base("Wind Direction", "", metadata) { }
    }

    public class Precipitation : Phenomenon
    {
        public Precipitation(string metadata) : base("Precipitation", "", metadata) { }
    }
}
