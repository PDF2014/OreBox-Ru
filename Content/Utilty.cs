using UnityEngine;
using NeoModLoader.services;

namespace OreBox.Content;

internal static class OreBoxUtils
{
    public static void OreBoxLog(string message)
    {
        LogService.LogInfo("[OreBox]: " + message);
    }

    public static void OreBoxError(string message)
    {
        LogService.LogError("[OreBox] Error:" + message);
    }
}