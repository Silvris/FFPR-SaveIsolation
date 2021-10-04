using HarmonyLib;
using Last.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFPR_SaveIsolation
{
    [HarmonyPatch(typeof(SaveSlotManager),nameof(SaveSlotManager.GetSavePath))]
    public sealed class SaveSlotManager_GetSlotPath : Il2CppSystem.Object
    {
        public SaveSlotManager_GetSlotPath(IntPtr ptr) : base(ptr)
        {

        }
        public static void Postfix(SaveSlotManager __instance, ref string __result)
        {
            EntryPoint.Instance.Log.LogInfo($"Changing path \"{__result} to {__result + "Isolated/"}");
            __result += "Isolated/";
        }
    }
}
