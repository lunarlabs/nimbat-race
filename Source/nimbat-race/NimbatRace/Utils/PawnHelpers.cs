using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace NimbatRace.Utils
{
    internal static class PawnHelpers
    {
        internal static bool IsNimbat(this Pawn pawn) => pawn?.kindDef?.race.defName.ToLower().Contains("nimbat") ?? false;
    }
}
