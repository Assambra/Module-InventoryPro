using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using Assambra.InventoryPro;
using Assambra.InventoryPro.UI;
using UnityEngine.Assertions;

namespace Assambra.InventoryPro
{
    /// <summary>
    /// A physical representation of a crafting station.
    /// </summary>
    [AddComponentMenu(InventoryPro.AddComponentMenuPath + "Triggers/Crafting standard trigger")]
    public class CraftingStandardTrigger : CraftingTriggerBase<CraftingWindowStandardUI>
    {
        protected override void SetWindow()
        {
            if (InventoryManager.instance.craftingStandard == null)
            {
                Debug.LogWarning("Crafting trigger in scene, but no crafting window found", transform);
                return;
            }

            craftingWindow = InventoryManager.instance.craftingStandard;
        }
    }
}