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
        public NimbatSettings Settings { get; set; }

        public NimbatRaceMod(ModContentPack content) : base(content)
        {
            Settings = base.GetSettings<NimbatSettings>();
            Settings.ApplySettings();
        }
    }
}