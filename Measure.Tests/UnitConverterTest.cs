using Nsar.Common.Measure.Models;
using System;
using Xunit;

namespace Nsar.Common.Measure.Tests
{
    public class UnitConverterTest
    {
        [Fact]
        public void Convert_UnitsFromEcTowerMetTable_ReturnsSI()
        {
            //# Arrange
            PhysicalQuantity expTemp        = new PhysicalQuantity(10, "C");
            PhysicalQuantity expSpeed       = new PhysicalQuantity(10, "m/s");
            PhysicalQuantity expDegree      = new PhysicalQuantity(10, "deg");
            PhysicalQuantity expPercent     = new PhysicalQuantity(10, "%");
            PhysicalQuantity expPrecip      = new PhysicalQuantity(0.01, "m");
            PhysicalQuantity expPressure    = new PhysicalQuantity(10000, "Pa");
            PhysicalQuantity expPar         = new PhysicalQuantity(0.00001, "mol/(m^2 s)", 6);
            PhysicalQuantity expVolt        = new PhysicalQuantity(10, "V");
            PhysicalQuantity expPressLower  = new PhysicalQuantity(10000, "Pa");
            PhysicalQuantity expRad         = new PhysicalQuantity(10, "kg/s^3");

            PhysicalQuantityConverter sut = new PhysicalQuantityConverter();

            //# Act
            PhysicalQuantity actTemp            = sut.Convert(new PhysicalQuantity(10, "C"));
            PhysicalQuantity actSpeed           = sut.Convert(new PhysicalQuantity(10, "m/s"));
            PhysicalQuantity actDegree          = sut.Convert(new PhysicalQuantity(10, "degrees"));
            PhysicalQuantity actPercent         = sut.Convert(new PhysicalQuantity(10, "%"));
            PhysicalQuantity actPrecip          = sut.Convert(new PhysicalQuantity(10, "mm"));
            PhysicalQuantity actPressure        = sut.Convert(new PhysicalQuantity(10, "kPa"));
            PhysicalQuantity actPar             = sut.Convert(new PhysicalQuantity(10, "umol/(s m^2)",6));
            PhysicalQuantity actVolt            = sut.Convert(new PhysicalQuantity(10, "V"));
            PhysicalQuantity actPressLower      = sut.Convert(new PhysicalQuantity(10, "kpa"));
            PhysicalQuantity actRad             = sut.Convert(new PhysicalQuantity(10, "W/m^2"));

            //# Assert
            Assert.Equal(expTemp      , actTemp      );
            Assert.Equal(expSpeed     , actSpeed     );
            Assert.Equal(expDegree    , actDegree    );
            Assert.Equal(expPercent   , actPercent   );
            Assert.Equal(expPrecip    , actPrecip    );
            Assert.Equal(expPressure  , actPressure  );
            Assert.Equal(expPar       , actPar       );
            Assert.Equal(expVolt      , actVolt      );
            Assert.Equal(expPressLower, actPressLower);
            Assert.Equal(expRad       , actRad);
        }
    }
}
