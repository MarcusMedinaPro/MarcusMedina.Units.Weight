using MarcusMedina.Units.Weight;
using MarcusMedina.Units.Weight.Metric;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Weight.Tests;

public class OverflowTests
{
    [Fact]
    public void Tonnes_LargeInt_DoesNotOverflow()
    {
        5000.Tonnes().Grams.Should().Be(5_000_000_000d);
    }

    [Fact]
    public void Kilograms_LargeInt_DoesNotOverflow()
    {
        3_000_000.Kilograms().Grams.Should().Be(3_000_000_000d);
    }
}
