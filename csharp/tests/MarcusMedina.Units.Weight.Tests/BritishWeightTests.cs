using MarcusMedina.Units.Weight;
using MarcusMedina.Units.Weight.Metric;
using MarcusMedina.Units.Weight.British;
using MarcusMedina.Units.Weight.BritishOld;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Weight.Tests;

public class BritishWeightTests
{
    [Fact]
    public void Kilograms_ToStone()
    {
        75.0.Kilograms().ToStone().Should().BeApproximately(11.811, 1e-3);
    }

    [Fact]
    public void Stone_ToKilograms()
    {
        1.Stone().ToKilograms().Should().BeApproximately(6.350, 1e-3);
    }

    [Fact]
    public void Pounds_ToKilograms()
    {
        1.Pounds().ToKilograms().Should().BeApproximately(0.45359, 1e-4);
    }

    [Fact]
    public void Ounces_ToGrams()
    {
        1.Ounces().ToGrams().Should().BeApproximately(28.3495, 1e-3);
    }

    [Fact]
    public void LongTons_ToKilograms()
    {
        1.LongTons().ToKilograms().Should().BeApproximately(1016.047, 1e-2);
    }

    [Fact]
    public void Kilograms_ToPounds()
    {
        1.Kilograms().ToPounds().Should().BeApproximately(2.20462, 1e-4);
    }

    [Fact]
    public void Grains_ToMilligrams()
    {
        1.Grains().ToMilligrams().Should().BeApproximately(64.799, 1e-2);
    }

    [Fact]
    public void Hundredweights_ToPounds()
    {
        1.Hundredweights().ToPounds().Should().BeApproximately(112.0, 1e-6);
    }
}

public class BritishOldWeightTests
{
    [Fact]
    public void TroyPounds_ToGrams()
    {
        1.TroyPounds().ToGrams().Should().BeApproximately(373.242, 1e-2);
    }

    [Fact]
    public void TroyOunces_ToGrams()
    {
        1.TroyOunces().ToGrams().Should().BeApproximately(31.103, 1e-2);
    }

    [Fact]
    public void Pennyweights_ToMilligrams()
    {
        1.Pennyweights().ToMilligrams().Should().BeApproximately(1555.17, 1e-1);
    }

    [Fact]
    public void Scruples_ToGrams()
    {
        1.Scruples().ToGrams().Should().BeApproximately(1.296, 1e-2);
    }

    [Fact]
    public void ApothecaryDrams_ToGrams()
    {
        1.ApothecaryDrams().ToGrams().Should().BeApproximately(3.888, 1e-2);
    }

    [Fact]
    public void TroyOunces_ToKilograms()
    {
        1.TroyOunces().ToKilograms().Should().BeApproximately(0.031103, 1e-5);
    }
}
