using BepInEx;
using HarmonyLib;
using System.Reflection;


namespace BoatDamageFix
{
    [BepInPlugin(PLUGIN_ID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PLUGIN_ID = "com.nandbrew.boatdamagefix";
        public const string PLUGIN_NAME = "Boat Update Hack";
        public const string PLUGIN_VERSION = "1.1.0";

        //--settings--
        //internal ConfigEntry<bool> someSetting;


        private void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PLUGIN_ID);
            //someSetting = Config.Bind("Settings", "Some setting", false);
        }
    }
}
