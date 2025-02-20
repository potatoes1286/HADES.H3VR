﻿using System;
using BepInEx;
using BepInEx.Logging;
using FistVR;
using static HADES.Utilities.Logging;
using PluginInfo = HADES.Utilities.PluginInfo;

namespace HADES.Core
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Mod;
        public static ManualLogSource ConsoleLogger;
        public Plugin()
        {
            Mod = this;
            Print($"Loading EHADS version {PluginInfo.VERSION}");
        }


        private void Start()
        {
            GM.CurrentPlayerBody.gameObject.AddComponent<HADES>();
            Print($"Loaded EHADS version {PluginInfo.VERSION}!");
        }
    }
}