using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Common.Measure.Models
{
    public class Measurement
    {
        private readonly string name;
        private readonly DateTime dateTime;
        private readonly double latitude;
        private readonly double longitude;
        private readonly PhysicalQuantity physicalQuantity;

        public string Name
        {
            get { return name; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
        }
        public double Latitude
        {
            get { return latitude; }
        }
        public double Longitude
        {
            get { return longitude; }
        }

        public PhysicalQuantity PhysicalQuantity
        {
            get { return physicalQuantity; }
        }

        public Measurement(
            string name,
            DateTime dateTime,
            double latitude,
            double longitude,
            PhysicalQuantity physicalQuantity)
        {
            //TODO: Error checking

            this.name = name;
            this.dateTime = dateTime;
            this.latitude = latitude;
            this.longitude = longitude;
            this.physicalQuantity = physicalQuantity;
        }
    }
}
