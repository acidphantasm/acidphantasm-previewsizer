using HarmonyLib;
using SPT.Reflection.Patching;
using System.Reflection;
using EFT.UI;

namespace acidphantasm_previewsizer.Patches
{
    internal class ItemSpecificationPanelPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(ItemSpecificationPanel), nameof(ItemSpecificationPanel.InitInteractionButtonsPanel));
        }

        [PatchPrefix]
        static bool Prefix(ItemSpecificationPanel __instance)
        {
            return __instance == null || !Plugin.ActionPanel;
        }
    }
}
