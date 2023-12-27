using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using ModelReplacement;
using BepInEx.Configuration;
using System;
using ReZeroModelAdditions.Replacements;

//using System.Numerics;

namespace ReZeroModelAdditions
{

    [BepInPlugin("tacocat.ReZeroModels", "ReZero Company", "1.0.0")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigFile config;

        // Universal config options 
        public static ConfigEntry<bool> enableMikuForAllSuits { get; private set; }
        public static ConfigEntry<bool> enableMikuAsDefault { get; private set; }
        public static ConfigEntry<string> suitNamesToEnableMiku { get; private set; }
        
        // Miku model specific config options
        public static ConfigEntry<float> UpdateRate { get; private set; }
        public static ConfigEntry<float> distanceDisablePhysics { get; private set; }
        public static ConfigEntry<bool> disablePhysicsAtRange { get; private set; }

        public void InitConfig()
        {
            return;
        }

        private void Awake()
        {
            config = base.Config;
            InitConfig();
            Assets.PopulateAssets();

            // Plugin startup logic


            ModelReplacementAPI.RegisterSuitModelReplacement("Emilia", typeof(EmiliaReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Beatrice", typeof(BeatriceReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Felix", typeof(FelixReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Rem", typeof(RemReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Ram", typeof(RamReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Subaru", typeof(SubaruReplacement));


            Harmony harmony = new Harmony("meow.MikuModelReplacement");
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {"meow.MikuModelReplacement"} is loaded!");
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "mbundle";
        public static AssetBundle MainAssetBundle = null;

        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().GetName().Name;
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                Console.WriteLine(GetAssemblyName() + "." + mainAssetBundleName);
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
        }
    }

}