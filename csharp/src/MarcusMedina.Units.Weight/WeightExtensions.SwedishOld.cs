namespace MarcusMedina.Units.Weight.SwedishOld;

/// <summary>
/// Historiska svenska viktenheter — det gamla viktlod-systemet (före 1889).
/// Baseras på det svenska handelsviktsystemet.
/// <code>
/// 75.0.Kilograms().ToSkålpund()   // ≈ 176.4 skålpund
/// 1.Skålpund().ToGrams()          // ≈ 425.08
/// 1.Lispund().ToKilograms()       // ≈ 8.50
/// </code>
/// </summary>
public static class SwedishOldWeightExtensions
{
    extension(int v)
    {
        /// <summary>1 ort ≈ 0.2102 g</summary>
        public Weight Ort() => new(v * 0.2102);
        /// <summary>1 kvintin = 1/32 lod ≈ 0.8298 g</summary>
        public Weight Kvintin() => new(v * 0.8298);
        /// <summary>1 lod = 1/32 skålpund ≈ 13.28 g</summary>
        public Weight Lod() => new(v * 13.28);
        /// <summary>1 skålpund = 425.076 g (svenska rikslod)</summary>
        public Weight Skålpund() => new(v * 425.076);
        /// <summary>1 lispund = 20 skålpund = 8501.52 g ≈ 8.5 kg</summary>
        public Weight Lispund() => new(v * 8501.52);
        /// <summary>1 centner = 100 skålpund = 42507.6 g ≈ 42.5 kg</summary>
        public Weight Centner() => new(v * 42507.6);
        /// <summary>1 skeppspund = 20 lispund = 400 skålpund = 170030.4 g ≈ 170 kg</summary>
        public Weight Skeppspund() => new(v * 170030.4);
    }

    extension(double v)
    {
        public Weight Ort() => new(v * 0.2102);
        public Weight Kvintin() => new(v * 0.8298);
        public Weight Lod() => new(v * 13.28);
        public Weight Skålpund() => new(v * 425.076);
        public Weight Lispund() => new(v * 8501.52);
        public Weight Centner() => new(v * 42507.6);
        public Weight Skeppspund() => new(v * 170030.4);
    }

    extension(Weight w)
    {
        public double ToOrt() => w.Grams / 0.2102;
        public double ToKvintin() => w.Grams / 0.8298;
        public double ToLod() => w.Grams / 13.28;
        public double ToSkålpund() => w.Grams / 425.076;
        public double ToLispund() => w.Grams / 8501.52;
        public double ToCentner() => w.Grams / 42507.6;
        public double ToSkeppspund() => w.Grams / 170030.4;
    }
}
