using System;
using acidphantasm_previewsizer.Patches;
using BepInEx;

namespace acidphantasm_previewsizer
{
    [BepInPlugin("com.acidphantasm.previewsizer", "acidphantasm-PreviewSizer", "1.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static bool ActionPanel;
        public static int PreviewMinHeight;

        private void Awake()
        {
            if (!VersionChecker.CheckEftVersion(Logger, Info, Config))
            {
                throw new Exception($"Invalid EFT Version");
            }
            
            new ItemInfoWindowLabelsPatch().Enable();
            new ItemSpecificationPanelPatch().Enable();

            PreviewSizerConfig.InitConfig(Config);
        }
    }
}
