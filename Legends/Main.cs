﻿using HarmonyLib;
using Legends.Utilities;
using UnityModManagerNet;

namespace Legends
{
    static class Main
    {
        public static bool Enabled;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony(modEntry.Info.Id);
            Utilities.Logger.ModEntry = modEntry;
            harmony.PatchAll();
            PostPatchInitializer.Initialize();
            return true;
        }

        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            Enabled = value;
            return true;
        }
    }
}
