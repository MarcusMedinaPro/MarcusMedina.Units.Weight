namespace MarcusMedina.Units.Weight.British;

/// <summary>
/// Moderna brittiska viktenheter (imperial system).
/// <code>
/// 75.0.Kilograms().ToStone()    // ≈ 11.81
/// 1.Stone().ToKilograms()       // ≈ 6.350
/// 1.LongTons().ToKilograms()    // ≈ 1016.05
/// </code>
/// </summary>
public static class BritishWeightExtensions
{
    /// <summary>1 grain = 0.06479891 g</summary>
    public static Weight Grains(this int v) => new(v * 0.06479891);
    public static Weight Grains(this double v) => new(v * 0.06479891);
    /// <summary>1 drachm = 1/16 oz = 1.7718452 g</summary>
    public static Weight Drachms(this int v) => new(v * 1.7718452);
    public static Weight Drachms(this double v) => new(v * 1.7718452);
    /// <summary>1 ounce = 28.349523125 g</summary>
    public static Weight Ounces(this int v) => new(v * 28.349523125);
    public static Weight Ounces(this double v) => new(v * 28.349523125);
    /// <summary>1 pound = 453.59237 g</summary>
    public static Weight Pounds(this int v) => new(v * 453.59237);
    public static Weight Pounds(this double v) => new(v * 453.59237);
    /// <summary>1 stone = 14 pounds = 6350.29318 g</summary>
    public static Weight Stone(this int v) => new(v * 6350.29318);
    public static Weight Stone(this double v) => new(v * 6350.29318);
    /// <summary>1 quarter = 2 stone = 28 pounds = 12700.58636 g</summary>
    public static Weight Quarters(this int v) => new(v * 12700.58636);
    public static Weight Quarters(this double v) => new(v * 12700.58636);
    /// <summary>1 hundredweight (long) = 8 stone = 112 pounds = 50802.34544 g</summary>
    public static Weight Hundredweights(this int v) => new(v * 50802.34544);
    public static Weight Hundredweights(this double v) => new(v * 50802.34544);
    /// <summary>1 long ton = 20 cwt = 2240 pounds = 1016046.9088 g</summary>
    public static Weight LongTons(this int v) => new(v * 1_016_046.9088);
    public static Weight LongTons(this double v) => new(v * 1_016_046.9088);

    public static double ToGrains(this Weight w) => w.Grams / 0.06479891;
    public static double ToDrachms(this Weight w) => w.Grams / 1.7718452;
    public static double ToOunces(this Weight w) => w.Grams / 28.349523125;
    public static double ToPounds(this Weight w) => w.Grams / 453.59237;
    public static double ToStone(this Weight w) => w.Grams / 6350.29318;
    public static double ToQuarters(this Weight w) => w.Grams / 12700.58636;
    public static double ToHundredweights(this Weight w) => w.Grams / 50802.34544;
    public static double ToLongTons(this Weight w) => w.Grams / 1_016_046.9088;
}
