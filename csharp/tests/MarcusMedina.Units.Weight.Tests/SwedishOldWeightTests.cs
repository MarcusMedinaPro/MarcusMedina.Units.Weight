using MarcusMedina.Units.Weight;
using MarcusMedina.Units.Weight.Metric;
using MarcusMedina.Units.Weight.SwedishOld;
using MarcusMedina.Units.Weight.British;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Weight.Tests;

public class SwedishOldWeightTests
{
    [Fact]
    public void Skålpund_ToGrams()
    {
        1.Skålpund().ToGrams().Should().BeApproximately(425.076, 1e-2);
    }

    [Fact]
    public void Kilograms_ToSkålpund()
    {
        75.0.Kilograms().ToSkålpund().Should().BeApproximately(176.44, 1e-1);
    }

    [Fact]
    public void Lispund_ToKilograms()
    {
        1.Lispund().ToKilograms().Should().BeApproximately(8.502, 1e-2);
    }

    [Fact]
    public void Skeppspund_ToKilograms()
    {
        1.Skeppspund().ToKilograms().Should().BeApproximately(170.030, 1e-2);
    }

    [Fact]
    public void Lod_ToGrams()
    {
        1.Lod().ToGrams().Should().BeApproximately(13.28, 1e-2);
    }

    [Fact]
    public void Centner_ToKilograms()
    {
        1.Centner().ToKilograms().Should().BeApproximately(42.508, 1e-2);
    }

    [Fact]
    public void DoubleOverload_Works()
    {
        0.5.Skålpund().ToGrams().Should().BeApproximately(212.538, 1e-2);
    }

    [Fact]
    public void CrossSystem_Skålpund_ToStone()
    {
        1.Skålpund().ToStone().Should().BeApproximately(0.06693, 1e-4);
    }
}
