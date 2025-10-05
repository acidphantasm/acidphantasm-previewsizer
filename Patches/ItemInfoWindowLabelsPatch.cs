using HarmonyLib;
using SPT.Reflection.Patching;
using System.Reflection;
using EFT;
using EFT.UI;
using EFT.UI.WeaponModding;
using UnityEngine.UI;
using UnityEngine;

namespace acidphantasm_previewsizer.Patches
{
    internal class ItemInfoWindowLabelsPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(ItemInfoWindowLabels), nameof(ItemInfoWindowLabels.Show));
        }

        [PatchPostfix]
        static void Postfix(ItemInfoWindowLabels __instance, GameObject ____previewPanel)
        {
            if (__instance == null) return;

            ____previewPanel.GetComponent<LayoutElement>().preferredHeight = Plugin._previewMinHeight;
            ____previewPanel.GetComponent<LayoutElement>().minHeight = Plugin._previewMinHeight;
        }
    }
}
