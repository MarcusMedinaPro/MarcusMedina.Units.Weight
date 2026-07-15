# MarcusMedina.Units.Weight

[![NuGet](https://img.shields.io/nuget/v/MarcusMedina.Units.Weight.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Weight/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/MarcusMedina.Units.Weight.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Weight/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=csharp&logoColor=white)](#)
[![.NET](https://img.shields.io/badge/.NET-10.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![Open Source](https://raw.githubusercontent.com/MarcusMedinaPro/MarcusMedina.Units.Weight/main/assets/open-source.svg)](https://opensource.org)
[![Build](https://img.shields.io/github/actions/workflow/status/MarcusMedinaPro/MarcusMedina.Units.Weight/release.yml?branch=main&label=Build&style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight/actions)
[![Signed](https://img.shields.io/badge/Signed-Sigstore-green?style=for-the-badge&logo=linux)](https://docs.sigstore.dev)
[![Wiki](https://img.shields.io/badge/docs-wiki-blue?style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight/wiki)

**Fluent weight unit conversion for .NET 10+** — metric, British (imperial, Troy and Apothecary), US customary, and historical Swedish units.

Convert between grams, pounds, stone, skålpund and more with a strongly-typed `Weight` struct — no more guessing which raw `double` means what, and no more mixing up a Troy ounce with an avoirdupois ounce by accident.

> These came to me while I was sitting with upper-secondary students, helping them work through their maths homework. They saw calculations; I saw code. We'd break each problem down into small pieces so it was easier to grasp, and then they'd work through it themselves — usually landing on "oh, so that's all it was?" after sitting there feeling completely lost about what the task even wanted from them. Helping them was genuinely fun, and it's what got me thinking about turning those exact tasks into code.
>
> In this case, I wanted each unit conversion to be broken into the same small, obvious steps I'd walk a student through by hand, not buried inside a single formula.

---

## Features

- ✅ **Metric** — ng, µg, mg, cg, dg, g, dag, hg, kg, tonne
- ✅ **US customary** — grain, dram, ounce, pound, short hundredweight, short ton
- ✅ **British imperial** — grain, drachm, ounce, pound, stone, quarter, hundredweight, long ton
- ✅ **British old (Troy & Apothecary)** — Troy grain, pennyweight, Troy ounce, Troy pound, scruple, apothecary dram, apothecary ounce
- ✅ **Historical Swedish** — ort, kvintin, lod, skålpund, lispund, centner, skeppspund
- ✅ **Strongly typed** — `Weight` struct instead of a raw `double`, so units can't be mixed up by accident
- ✅ **Fluent API** — `1.Stone().ToKilograms()`
- ✅ **Comparable & arithmetic** — `+`, `-`, `*`, `/`, and full comparison operators
- ✅ **Zero dependencies** — pure .NET, no external packages

---

## Installation

```bash
dotnet add package MarcusMedina.Units.Weight
```

**Requirements:** .NET 10.0+, C# 14.0+

---

## Quick Start

```csharp
using MarcusMedina.Units.Weight.Metric;
using MarcusMedina.Units.Weight.British;
using MarcusMedina.Units.Weight.SwedishOld;

// Create a Weight from any supported unit
Weight package = 2.5.Kilograms();
Weight person  = 11.Stone();

// Convert to whatever unit you need
double pounds     = person.ToPounds();      // 154
double skalpund   = package.ToSkålpund();   // ≈ 5.88

// Arithmetic works directly on Weight values
Weight total = package + 1.Pounds();

// Comparisons
bool heavier = person > package;
```

---

## API Overview

| Namespace | Unit family |
|-----------|-------------|
| `MarcusMedina.Units.Weight.Metric` | ng, µg, mg, cg, dg, g, dag, hg, kg, tonne |
| `MarcusMedina.Units.Weight.US` | grain, dram, ounce, pound, short hundredweight, short ton |
| `MarcusMedina.Units.Weight.British` | grain, drachm, ounce, pound, stone, quarter, hundredweight, long ton |
| `MarcusMedina.Units.Weight.BritishOld` | Troy grain, pennyweight, Troy ounce, Troy pound, scruple, apothecary dram, apothecary ounce |
| `MarcusMedina.Units.Weight.SwedishOld` | ort, kvintin, lod, skålpund, lispund, centner, skeppspund |

Every unit exposes a creation extension (`1.Stone()`) and a conversion extension
(`weight.ToStone()`). The `Weight` struct itself always stores the value in grams,
so mixing units in the same expression is always safe.

---

## Testing

```bash
cd csharp
dotnet test --configuration Release
```

Tests: **44 passed** — covering all unit families, arithmetic operators, and edge cases.

---

## License

MIT — see [LICENSE](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight/blob/main/LICENSE) for details.

---

## Built with Human + AI Collaboration

This library was written by **Marcus Medina** together with **Claude Code** (Anthropic) — not through "vibe coding" where you just describe and accept, but through genuine collaboration: planning together, reviewing each other's decisions, pushing back when something felt wrong, and iterating until the result felt right.

The goal was always to write code worth reading and code worth using — the kind a student can open, understand, and learn from, and the kind any programmer can drop into real, professional work without wanting to rewrite it from scratch. AI was a partner in that process, not a shortcut around it.

If you're curious about this way of working, the source code and git history are open. Every decision has a reason behind it.

## Made for Curious Minds

This library was built with students in mind — not as a black box to copy and paste, but as a real-world example of how clean, purposeful code is written and shared.

Whether you're discovering C# for the first time, need a reliable helper for your school project, or are simply trying to fall in love with writing code — you're exactly who this was made for.

The source is open. Read it, fork it, break it, improve it. That's the whole point.

And if this library saved you an afternoon, or made something click that didn't before — that's everything.

*Non-students are equally welcome. Good code doesn't care about your diploma.*

⭐ If this helped you, consider starring the project on GitHub — it helps other students find it too.

💬 Have an idea, a feature request, or just want to say hi? Open an issue on GitHub — I'd love to hear from you.

## Package Integrity

All releases are signed with [cosign](https://docs.sigstore.dev) (Sigstore keyless signing).

To verify a downloaded package, download both the `.nupkg` and its `.sigstore.json` bundle from the [GitHub Release](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight/releases), then run:

```bash
cosign verify-blob <package.nupkg> \
  --bundle <package.nupkg.sigstore.json> \
  --certificate-identity-regexp "https://github.com/MarcusMedinaPro/.*/release.yml" \
  --certificate-oidc-issuer https://token.actions.githubusercontent.com
```

Expected output: `Verified OK`

## Related Projects

- [MarcusMedina.Units.Area](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Area) — Fluent area unit conversion
- [MarcusMedina.Units.Volume](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume) — Fluent volume unit conversion
- [MarcusMedina.Units.Math](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Math) — Unit-aware mathematical operations
- [MarcusMedina.Maths.Algebra](https://github.com/MarcusMedinaPro/MarcusMedina.Maths.Algebra) — Algebraic expressions and symbolic math
