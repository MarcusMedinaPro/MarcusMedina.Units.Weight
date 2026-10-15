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
    extension(int v)
    {
        /// <summary>1 grain = 0.06479891 g</summary>
        public Weight Grains() => new(v * 0.06479891);
        /// <summary>1 drachm = 1/16 oz = 1.7718452 g</summary>
        public Weight Drachms() => new(v * 1.7718452);
        /// <summary>1 ounce = 28.349523125 g</summary>
        public Weight Ounces() => new(v * 28.349523125);
        /// <summary>1 pound = 453.59237 g</summary>
        public Weight Pounds() => new(v * 453.59237);
        /// <summary>1 stone = 14 pounds = 6350.29318 g</summary>
        public Weight Stone() => new(v * 6350.29318);
        /// <summary>1 quarter = 2 stone = 28 pounds = 12700.58636 g</summary>
        public Weight Quarters() => new(v * 12700.58636);
        /// <summary>1 hundredweight (long) = 8 stone = 112 pounds = 50802.34544 g</summary>
        public Weight Hundredweights() => new(v * 50802.34544);
        /// <summary>1 long ton = 20 cwt = 2240 pounds = 1016046.9088 g</summary>
        public Weight LongTons() => new(v * 1_016_046.9088);
    }

    extension(double v)
    {
        public Weight Grains() => new(v * 0.06479891);
        public Weight Drachms() => new(v * 1.7718452);
        public Weight Ounces() => new(v * 28.349523125);
        public Weight Pounds() => new(v * 453.59237);
        public Weight Stone() => new(v * 6350.29318);
        public Weight Quarters() => new(v * 12700.58636);
        public Weight Hundredweights() => new(v * 50802.34544);
        public Weight LongTons() => new(v * 1_016_046.9088);
    }

    extension(Weight w)
    {
        public double ToGrains() => w.Grams / 0.06479891;
        public double ToDrachms() => w.Grams / 1.7718452;
        public double ToOunces() => w.Grams / 28.349523125;
        public double ToPounds() => w.Grams / 453.59237;
        public double ToStone() => w.Grams / 6350.29318;
        public double ToQuarters() => w.Grams / 12700.58636;
        public double ToHundredweights() => w.Grams / 50802.34544;
        public double ToLongTons() => w.Grams / 1_016_046.9088;
    }
}
