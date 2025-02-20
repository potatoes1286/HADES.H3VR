using System;
using BepInEx.Logging;
using FistVR;
using HADES.Core;
using UnityEngine;

namespace HADES.Utilities
{
    public static class Common
    {
        public static readonly WaitForSeconds WAIT_A_SEX = new WaitForSeconds(1);
    }
    
    public struct PluginInfo
    {
        public const string NAME = "HADES.Core";
        public const string GUID = "net.frityet.ehads";
        public const string VERSION = "1.0.0";
    }

    public static class Logging
    {
        public static void Print(object msg, LogLevel level = LogLevel.Info)
        {
            Plugin.ConsoleLogger.Log(level, msg);
        }


        public static class Debug
        {
            public static void Print(object msg)
            {
                Plugin.ConsoleLogger.Log(LogLevel.Debug, msg);
            }
        }
    }

    public class Tuple<T1, T2>
    {
        public Tuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T1 Item1 { get; }
        public T2 Item2 { get; }
    }
}