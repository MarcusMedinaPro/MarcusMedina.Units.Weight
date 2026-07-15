using MarcusMedina.Units.Weight;
using MarcusMedina.Units.Weight.Metric;
using MarcusMedina.Units.Weight.US;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Weight.Tests;

public class USWeightTests
{
    [Fact]
    public void ShortTons_ToKilograms()
    {
        1.ShortTons().ToKilograms().Should().BeApproximately(907.185, 1e-2);
    }

    [Fact]
    public void ShortTons_ToShortHundredweights()
    {
        1.ShortTons().ToShortHundredweights().Should().BeApproximately(20.0, 1e-9);
    }

    [Fact]
    public void Pounds_ToShortTons()
    {
        2000.Pounds().ToShortTons().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void Ounces_ToPounds()
    {
        16.Ounces().ToPounds().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void ShortHundredweights_ToPounds()
    {
        1.ShortHundredweights().ToPounds().Should().BeApproximately(100.0, 1e-6);
    }

    [Fact]
    public void Kilograms_ToPounds()
    {
        1.Kilograms().ToPounds().Should().BeApproximately(2.20462, 1e-4);
    }
}
