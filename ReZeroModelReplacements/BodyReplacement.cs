using ModelReplacement;
using UnityEngine;

namespace ReZeroModelAdditions.Replacements
{
    public class EmiliaReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "emiliaPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class BeatriceReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "beatricePrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class FelixReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "felixPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class RamReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "ramPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class RemReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "remPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class SubaruReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "subaruPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class FeltReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "feltPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class EmiliaPajamasReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "emiliaPajamasPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }

    public class ReinhardReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "reinhardPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }
}
