namespace MarcusMedina.Units.Weight.US;

/// <summary>
/// Amerikanska viktenheter (US customary).
/// Pound och ounce är identiska med brittiska imperial; short ton skiljer sig från long ton.
/// <code>
/// 1.ShortTons().ToLongTons()    // ≈ 0.8929
/// 2000.Pounds().ToShortTons()   // 1.0
/// </code>
/// </summary>
public static class USWeightExtensions
{
    /// <summary>1 grain = 0.06479891 g</summary>
    public static Weight Grains(this int v) => new(v * 0.06479891);
    public static Weight Grains(this double v) => new(v * 0.06479891);
    /// <summary>1 dram = 1.7718452 g</summary>
    public static Weight Drams(this int v) => new(v * 1.7718452);
    public static Weight Drams(this double v) => new(v * 1.7718452);
    /// <summary>1 ounce = 28.349523125 g</summary>
    public static Weight Ounces(this int v) => new(v * 28.349523125);
    public static Weight Ounces(this double v) => new(v * 28.349523125);
    /// <summary>1 pound = 453.59237 g</summary>
    public static Weight Pounds(this int v) => new(v * 453.59237);
    public static Weight Pounds(this double v) => new(v * 453.59237);
    /// <summary>1 short hundredweight = 100 lbs = 45359.237 g</summary>
    public static Weight ShortHundredweights(this int v) => new(v * 45359.237);
    public static Weight ShortHundredweights(this double v) => new(v * 45359.237);
    /// <summary>1 short ton = 2000 lbs = 907184.74 g</summary>
    public static Weight ShortTons(this int v) => new(v * 907184.74);
    public static Weight ShortTons(this double v) => new(v * 907184.74);

    public static double ToGrains(this Weight w) => w.Grams / 0.06479891;
    public static double ToDrams(this Weight w) => w.Grams / 1.7718452;
    public static double ToOunces(this Weight w) => w.Grams / 28.349523125;
    public static double ToPounds(this Weight w) => w.Grams / 453.59237;
    public static double ToShortHundredweights(this Weight w) => w.Grams / 45359.237;
    public static double ToShortTons(this Weight w) => w.Grams / 907184.74;
}
