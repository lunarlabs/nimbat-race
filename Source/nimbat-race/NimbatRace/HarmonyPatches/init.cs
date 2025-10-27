using System.Reflection;
using HarmonyLib;
using Verse;

namespace NimbatRace.HarmonyPatches
{
    [StaticConstructorOnStartup]
    internal static class Init
    {
        static Init()
        {
            NimbatRaceMod.LogMessage("Patching with Harmony...");
            var harmony = new Harmony("NimbatRace");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}