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
    /// <summary>1 ort ≈ 0.2102 g</summary>
    public static Weight Ort(this int v) => new(v * 0.2102);
    public static Weight Ort(this double v) => new(v * 0.2102);
    /// <summary>1 kvintin = 1/32 lod ≈ 0.8298 g</summary>
    public static Weight Kvintin(this int v) => new(v * 0.8298);
    public static Weight Kvintin(this double v) => new(v * 0.8298);
    /// <summary>1 lod = 1/32 skålpund ≈ 13.28 g</summary>
    public static Weight Lod(this int v) => new(v * 13.28);
    public static Weight Lod(this double v) => new(v * 13.28);
    /// <summary>1 skålpund = 425.076 g (svenska rikslod)</summary>
    public static Weight Skålpund(this int v) => new(v * 425.076);
    public static Weight Skålpund(this double v) => new(v * 425.076);
    /// <summary>1 lispund = 20 skålpund = 8501.52 g ≈ 8.5 kg</summary>
    public static Weight Lispund(this int v) => new(v * 8501.52);
    public static Weight Lispund(this double v) => new(v * 8501.52);
    /// <summary>1 centner = 100 skålpund = 42507.6 g ≈ 42.5 kg</summary>
    public static Weight Centner(this int v) => new(v * 42507.6);
    public static Weight Centner(this double v) => new(v * 42507.6);
    /// <summary>1 skeppspund = 20 lispund = 400 skålpund = 170030.4 g ≈ 170 kg</summary>
    public static Weight Skeppspund(this int v) => new(v * 170030.4);
    public static Weight Skeppspund(this double v) => new(v * 170030.4);

    public static double ToOrt(this Weight w) => w.Grams / 0.2102;
    public static double ToKvintin(this Weight w) => w.Grams / 0.8298;
    public static double ToLod(this Weight w) => w.Grams / 13.28;
    public static double ToSkålpund(this Weight w) => w.Grams / 425.076;
    public static double ToLispund(this Weight w) => w.Grams / 8501.52;
    public static double ToCentner(this Weight w) => w.Grams / 42507.6;
    public static double ToSkeppspund(this Weight w) => w.Grams / 170030.4;
}
