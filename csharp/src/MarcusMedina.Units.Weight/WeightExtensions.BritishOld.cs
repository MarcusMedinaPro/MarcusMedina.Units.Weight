namespace MarcusMedina.Units.Weight.BritishOld;

/// <summary>
/// Historiska brittiska viktenheter — Troy och Apothecary-system.
/// <code>
/// 1.TroyPounds().ToGrams()        // ≈ 373.24
/// 1.TroyOunces().ToGrams()        // ≈ 31.10
/// 1.Pennyweights().ToMilligrams() // ≈ 1555.17
/// </code>
/// </summary>
public static class BritishOldWeightExtensions
{
    // ─── Troy-system ───
    /// <summary>1 Troy grain = 0.06479891 g (samma som imperial grain)</summary>
    public static Weight TroyGrains(this int v) => new(v * 0.06479891);
    public static Weight TroyGrains(this double v) => new(v * 0.06479891);
    /// <summary>1 pennyweight = 24 Troy grains = 1.55517384 g</summary>
    public static Weight Pennyweights(this int v) => new(v * 1.55517384);
    public static Weight Pennyweights(this double v) => new(v * 1.55517384);
    /// <summary>1 Troy ounce = 20 pennyweights = 31.1034768 g</summary>
    public static Weight TroyOunces(this int v) => new(v * 31.1034768);
    public static Weight TroyOunces(this double v) => new(v * 31.1034768);
    /// <summary>1 Troy pound = 12 Troy ounces = 373.2417216 g</summary>
    public static Weight TroyPounds(this int v) => new(v * 373.2417216);
    public static Weight TroyPounds(this double v) => new(v * 373.2417216);

    // ─── Apothecary-system ───
    /// <summary>1 scruple = 20 grains = 1.2959782 g</summary>
    public static Weight Scruples(this int v) => new(v * 1.2959782);
    public static Weight Scruples(this double v) => new(v * 1.2959782);
    /// <summary>1 apothecary dram = 3 scruples = 3.8879346 g</summary>
    public static Weight ApothecaryDrams(this int v) => new(v * 3.8879346);
    public static Weight ApothecaryDrams(this double v) => new(v * 3.8879346);
    /// <summary>1 apothecary ounce = 8 drams = 31.1034768 g</summary>
    public static Weight ApothecaryOunces(this int v) => new(v * 31.1034768);
    public static Weight ApothecaryOunces(this double v) => new(v * 31.1034768);

    public static double ToTroyGrains(this Weight w) => w.Grams / 0.06479891;
    public static double ToPennyweights(this Weight w) => w.Grams / 1.55517384;
    public static double ToTroyOunces(this Weight w) => w.Grams / 31.1034768;
    public static double ToTroyPounds(this Weight w) => w.Grams / 373.2417216;
    public static double ToScruples(this Weight w) => w.Grams / 1.2959782;
    public static double ToApothecaryDrams(this Weight w) => w.Grams / 3.8879346;
    public static double ToApothecaryOunces(this Weight w) => w.Grams / 31.1034768;
}
