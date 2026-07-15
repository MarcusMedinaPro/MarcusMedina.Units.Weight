using MarcusMedina.Units.Weight;
using MarcusMedina.Units.Weight.Metric;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Weight.Tests;

public class WeightStructTests
{
    [Fact]
    public void Weight_StoresGrams()
    {
        var w = new Weight(100);
        w.Grams.Should().Be(100);
    }

    [Fact]
    public void Weight_Addition()
    {
        (new Weight(100) + new Weight(50)).Grams.Should().Be(150);
    }

    [Fact]
    public void Weight_Subtraction()
    {
        (new Weight(100) - new Weight(30)).Grams.Should().Be(70);
    }

    [Fact]
    public void Weight_Multiplication()
    {
        (new Weight(100) * 3).Grams.Should().Be(300);
    }

    [Fact]
    public void Weight_DivisionByFactor()
    {
        (new Weight(100) / 4).Grams.Should().Be(25);
    }

    [Fact]
    public void Weight_DivisionByWeight()
    {
        (new Weight(100) / new Weight(25)).Should().Be(4.0);
    }

    [Fact]
    public void Weight_Equality()
    {
        (new Weight(100) == new Weight(100)).Should().BeTrue();
        (new Weight(100) != new Weight(101)).Should().BeTrue();
    }

    [Fact]
    public void Weight_Comparison()
    {
        (new Weight(100) < new Weight(200)).Should().BeTrue();
        (new Weight(200) > new Weight(100)).Should().BeTrue();
    }

    [Fact]
    public void Weight_ToString()
    {
        new Weight(42.5).ToString().Should().Be("42.5 g");
    }
}

public class MetricWeightTests
{
    [Fact]
    public void Kilograms_ToGrams()
    {
        1.Kilograms().ToGrams().Should().BeApproximately(1000.0, 1e-9);
    }

    [Fact]
    public void Grams_ToKilograms()
    {
        1000.Grams().ToKilograms().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void Milligrams_ToGrams()
    {
        1000.Milligrams().ToGrams().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void Tonnes_ToKilograms()
    {
        1.Tonnes().ToKilograms().Should().BeApproximately(1000.0, 1e-9);
    }

    [Fact]
    public void Hectograms_ToGrams()
    {
        5.Hectograms().ToGrams().Should().BeApproximately(500.0, 1e-9);
    }

    [Fact]
    public void Micrograms_ToMilligrams()
    {
        1000.0.Micrograms().ToMilligrams().Should().BeApproximately(1.0, 1e-6);
    }

    [Fact]
    public void DoubleOverload_Works()
    {
        1.5.Kilograms().ToGrams().Should().BeApproximately(1500.0, 1e-9);
    }
}
