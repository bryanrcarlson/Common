using System;
using GeoCoordinatePortable;

namespace Nsar.Common.UnitOfMeasure
{
    // TODO: Implement better unit system instead of simply strings
    // TODO: UDUNITS? http://www.unidata.ucar.edu/software/udunits/#home

    public interface IMeasurement
    {
        double NumericalValue { get; }
        string Unit { get; }
        IPhenomenon Phenomenon { get; }
    }

    public interface ITemperalMeasurement : IMeasurement
    {
        DateTime DateTime { get; }
    }

    public interface ISpatialTemperalMeasurement : ITemperalMeasurement
    {
        GeoCoordinate GeoCoordinate { get; }
    }

    public interface IQuality
    {
        //TODO: Implement
        //QualityCode QualityCode { get; }
        //Testing a change // Change
    }

    public class Measurement : IMeasurement
    {
        private readonly double numericalValue;
        private readonly string unit;
        private readonly IPhenomenon phenomenon;

        public Measurement(double numericalValue, string unit, IPhenomenon phenomenon)
        {
            this.numericalValue = numericalValue;
            this.unit = unit;
            this.phenomenon = phenomenon;
        }

        public double NumericalValue { get { return this.numericalValue; } }
        public string Unit { get { return this.unit; } }
        public IPhenomenon Phenomenon { get { return this.phenomenon; } }
    }

    public class TemperalMeasurement : Measurement, ITemperalMeasurement
    {
        private readonly DateTime dateTime;

        public TemperalMeasurement(
            double value,
            string unit,
            IPhenomenon phenomenon,
            DateTime dateTime)
            : base(value, unit, phenomenon)
        {
            this.dateTime = dateTime;
        }

        public DateTime DateTime { get { return this.dateTime; } }
    }

    // TODO: SpatialTemperalMeasurement

    public class MeasurementComplete : TemperalMeasurement, ISpatialTemperalMeasurement, IQuality
    {
        private readonly GeoCoordinate geoCoordinate;

        public MeasurementComplete(double value,
            string unit,
            IPhenomenon phenomenon,
            DateTime dateTime,
            GeoCoordinate geoCoordinate)
            : base(value, unit, phenomenon, dateTime)
        {
            this.geoCoordinate = geoCoordinate;
        }

        public GeoCoordinate GeoCoordinate { get { return this.geoCoordinate; } }
        //public QualityCode QualityCode { get { return this.qualityCode; } }
    }
}
