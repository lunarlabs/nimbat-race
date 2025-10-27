using System;
using System.Collections.Generic;
using System.Xml;
using HarmonyLib;
using NimbatRace.PersistentData;
using RimWorld;
using UnityEngine;
using Verse;

namespace NimbatRace
{
    public class NimbatRaceMod : Mod
    {
        public static string MODSHORTID => "NimbatRace";
        public static string MODPREFIX => "[" + MODSHORTID + "] ";
        public NimbatSettings Settings { get; set; }
        public static Harmony harmony;

        public NimbatRaceMod(ModContentPack content) : base(content)
        {
            LogMessage("This is the Nimbat Race Mod");
            Settings = base.GetSettings<NimbatSettings>();
            Settings.ApplySettings();
        }

        public static void LogMessage(string message)
        {
            Log.Message(MODPREFIX + message);
        }

        public static void LogWarning(string message)
        {
            Log.Warning(MODPREFIX + message);
        }

        public static void LogError(string message)
        {
            Log.Error(MODPREFIX + message);
        }
    }
}