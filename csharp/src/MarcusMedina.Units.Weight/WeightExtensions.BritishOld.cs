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

    extension(int v)
    {
        /// <summary>1 Troy grain = 0.06479891 g (samma som imperial grain)</summary>
        public Weight TroyGrains() => new(v * 0.06479891);
        /// <summary>1 pennyweight = 24 Troy grains = 1.55517384 g</summary>
        public Weight Pennyweights() => new(v * 1.55517384);
        /// <summary>1 Troy ounce = 20 pennyweights = 31.1034768 g</summary>
        public Weight TroyOunces() => new(v * 31.1034768);
        /// <summary>1 Troy pound = 12 Troy ounces = 373.2417216 g</summary>
        public Weight TroyPounds() => new(v * 373.2417216);
    }

    extension(double v)
    {
        public Weight TroyGrains() => new(v * 0.06479891);
        public Weight Pennyweights() => new(v * 1.55517384);
        public Weight TroyOunces() => new(v * 31.1034768);
        public Weight TroyPounds() => new(v * 373.2417216);
    }

    // ─── Apothecary-system ───

    extension(int v)
    {
        /// <summary>1 scruple = 20 grains = 1.2959782 g</summary>
        public Weight Scruples() => new(v * 1.2959782);
        /// <summary>1 apothecary dram = 3 scruples = 3.8879346 g</summary>
        public Weight ApothecaryDrams() => new(v * 3.8879346);
        /// <summary>1 apothecary ounce = 8 drams = 31.1034768 g</summary>
        public Weight ApothecaryOunces() => new(v * 31.1034768);
    }

    extension(double v)
    {
        public Weight Scruples() => new(v * 1.2959782);
        public Weight ApothecaryDrams() => new(v * 3.8879346);
        public Weight ApothecaryOunces() => new(v * 31.1034768);
    }

    extension(Weight w)
    {
        public double ToTroyGrains() => w.Grams / 0.06479891;
        public double ToPennyweights() => w.Grams / 1.55517384;
        public double ToTroyOunces() => w.Grams / 31.1034768;
        public double ToTroyPounds() => w.Grams / 373.2417216;
        public double ToScruples() => w.Grams / 1.2959782;
        public double ToApothecaryDrams() => w.Grams / 3.8879346;
        public double ToApothecaryOunces() => w.Grams / 31.1034768;
    }
}
