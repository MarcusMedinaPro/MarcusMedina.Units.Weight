using System.Globalization;

namespace MarcusMedina.Units.Weight;

/// <summary>
/// Representerar en vikt med gram som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera gram-värdet.
/// </summary>
public readonly struct Weight : IComparable<Weight>, IEquatable<Weight>
{
    /// <summary>Värdet i gram (basenhet).</summary>
    public double Grams { get; }

    public Weight(double grams) { Grams = grams; }

    public int CompareTo(Weight other) => Grams.CompareTo(other.Grams);
    public bool Equals(Weight other) => Grams.Equals(other.Grams);
    public override bool Equals(object? obj) => obj is Weight w && Equals(w);
    public override int GetHashCode() => HashCode.Combine(Grams);
    public override string ToString() => $"{Grams.ToString("G", CultureInfo.InvariantCulture)} g";

    public static bool operator ==(Weight a, Weight b) => a.Equals(b);
    public static bool operator !=(Weight a, Weight b) => !(a == b);
    public static bool operator <(Weight a, Weight b) => a.Grams < b.Grams;
    public static bool operator >(Weight a, Weight b) => a.Grams > b.Grams;
    public static bool operator <=(Weight a, Weight b) => a.Grams <= b.Grams;
    public static bool operator >=(Weight a, Weight b) => a.Grams >= b.Grams;
    public static Weight operator +(Weight a, Weight b) => new(a.Grams + b.Grams);
    public static Weight operator -(Weight a, Weight b) => new(a.Grams - b.Grams);
    public static Weight operator *(Weight w, double factor) => new(w.Grams * factor);
    public static Weight operator /(Weight w, double divisor) => new(w.Grams / divisor);
    public static double operator /(Weight a, Weight b) => a.Grams / b.Grams;
}
