namespace MarcusMedina.Units.Weight.Metric;

/// <summary>
/// Metriska viktenheter — SI-standard med gram som basenhet.
/// <code>
/// 75.0.Kilograms().ToPounds()    // ≈ 165.35
/// 1000.Grams().ToKilograms()     // 1.0
/// </code>
/// </summary>
public static class MetricWeightExtensions
{
    public static Weight Nanograms(this int v) => new(v * 1e-9);
    public static Weight Nanograms(this double v) => new(v * 1e-9);
    public static Weight Micrograms(this int v) => new(v * 1e-6);
    public static Weight Micrograms(this double v) => new(v * 1e-6);
    public static Weight Milligrams(this int v) => new(v * 0.001);
    public static Weight Milligrams(this double v) => new(v * 0.001);
    public static Weight Centigrams(this int v) => new(v * 0.01);
    public static Weight Centigrams(this double v) => new(v * 0.01);
    public static Weight Decigrams(this int v) => new(v * 0.1);
    public static Weight Decigrams(this double v) => new(v * 0.1);
    public static Weight Grams(this int v) => new(v);
    public static Weight Grams(this double v) => new(v);
    public static Weight Decagrams(this int v) => new(v * 10);
    public static Weight Decagrams(this double v) => new(v * 10);
    public static Weight Hectograms(this int v) => new(v * 100);
    public static Weight Hectograms(this double v) => new(v * 100);
    public static Weight Kilograms(this int v) => new(v * 1000);
    public static Weight Kilograms(this double v) => new(v * 1000);
    public static Weight Tonnes(this int v) => new(v * 1_000_000);
    public static Weight Tonnes(this double v) => new(v * 1_000_000);

    public static double ToNanograms(this Weight w) => w.Grams / 1e-9;
    public static double ToMicrograms(this Weight w) => w.Grams / 1e-6;
    public static double ToMilligrams(this Weight w) => w.Grams / 0.001;
    public static double ToCentigrams(this Weight w) => w.Grams / 0.01;
    public static double ToDecigrams(this Weight w) => w.Grams / 0.1;
    public static double ToGrams(this Weight w) => w.Grams;
    public static double ToDecagrams(this Weight w) => w.Grams / 10;
    public static double ToHectograms(this Weight w) => w.Grams / 100;
    public static double ToKilograms(this Weight w) => w.Grams / 1000;
    public static double ToTonnes(this Weight w) => w.Grams / 1_000_000;
}
