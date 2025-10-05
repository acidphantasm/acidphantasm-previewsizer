using acidphantasm_previewsizer.Patches;
using BepInEx;

namespace acidphantasm_previewsizer
{
    [BepInPlugin("com.acidphantasm.previewsizer", "acidphantasm-PreviewSizer", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static bool _actionPanel;
        public static int _previewMinHeight;

        private void Awake()
        {
            new ItemInfoWindowLabelsPatch().Enable();
            new ItemSpecificationPanelPatch().Enable();

            PreviewSizerConfig.InitConfig(Config);
        }
    }
}
