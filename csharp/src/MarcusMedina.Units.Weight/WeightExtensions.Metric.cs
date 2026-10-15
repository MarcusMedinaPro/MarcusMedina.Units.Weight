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
    extension(int v)
    {
        public Weight Nanograms() => new(v * 1e-9);
        public Weight Micrograms() => new(v * 1e-6);
        public Weight Milligrams() => new(v * 0.001);
        public Weight Centigrams() => new(v * 0.01);
        public Weight Decigrams() => new(v * 0.1);
        public Weight Grams() => new(v);
        public Weight Decagrams() => new(v * 10.0);
        public Weight Hectograms() => new(v * 100.0);
        public Weight Kilograms() => new(v * 1000.0);
        public Weight Tonnes() => new(v * 1_000_000.0);
    }

    extension(double v)
    {
        public Weight Nanograms() => new(v * 1e-9);
        public Weight Micrograms() => new(v * 1e-6);
        public Weight Milligrams() => new(v * 0.001);
        public Weight Centigrams() => new(v * 0.01);
        public Weight Decigrams() => new(v * 0.1);
        public Weight Grams() => new(v);
        public Weight Decagrams() => new(v * 10);
        public Weight Hectograms() => new(v * 100);
        public Weight Kilograms() => new(v * 1000);
        public Weight Tonnes() => new(v * 1_000_000);
    }

    extension(Weight w)
    {
        public double ToNanograms() => w.Grams / 1e-9;
        public double ToMicrograms() => w.Grams / 1e-6;
        public double ToMilligrams() => w.Grams / 0.001;
        public double ToCentigrams() => w.Grams / 0.01;
        public double ToDecigrams() => w.Grams / 0.1;
        public double ToGrams() => w.Grams;
        public double ToDecagrams() => w.Grams / 10;
        public double ToHectograms() => w.Grams / 100;
        public double ToKilograms() => w.Grams / 1000;
        public double ToTonnes() => w.Grams / 1_000_000;
    }
}
