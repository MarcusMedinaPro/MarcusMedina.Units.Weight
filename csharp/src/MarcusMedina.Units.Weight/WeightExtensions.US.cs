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
    extension(int v)
    {
        /// <summary>1 grain = 0.06479891 g</summary>
        public Weight Grains() => new(v * 0.06479891);
        /// <summary>1 dram = 1.7718452 g</summary>
        public Weight Drams() => new(v * 1.7718452);
        /// <summary>1 ounce = 28.349523125 g</summary>
        public Weight Ounces() => new(v * 28.349523125);
        /// <summary>1 pound = 453.59237 g</summary>
        public Weight Pounds() => new(v * 453.59237);
        /// <summary>1 short hundredweight = 100 lbs = 45359.237 g</summary>
        public Weight ShortHundredweights() => new(v * 45359.237);
        /// <summary>1 short ton = 2000 lbs = 907184.74 g</summary>
        public Weight ShortTons() => new(v * 907184.74);
    }

    extension(double v)
    {
        public Weight Grains() => new(v * 0.06479891);
        public Weight Drams() => new(v * 1.7718452);
        public Weight Ounces() => new(v * 28.349523125);
        public Weight Pounds() => new(v * 453.59237);
        public Weight ShortHundredweights() => new(v * 45359.237);
        public Weight ShortTons() => new(v * 907184.74);
    }

    extension(Weight w)
    {
        public double ToGrains() => w.Grams / 0.06479891;
        public double ToDrams() => w.Grams / 1.7718452;
        public double ToOunces() => w.Grams / 28.349523125;
        public double ToPounds() => w.Grams / 453.59237;
        public double ToShortHundredweights() => w.Grams / 45359.237;
        public double ToShortTons() => w.Grams / 907184.74;
    }
}
