using System;
using System.Collections;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro;
using UnityEngine;

namespace Assambra.InventoryPro
{
    public interface ICraftingActionValidator
    {
        GameObject gameObject { get; }
        Transform transform { get; }
        CraftingProgressContainer progressContainer { get; }

//        bool CanCraftBlueprint(InventoryCraftingBlueprint blueprint, bool alsoScanBank, int craftCount);
        bool CanCraftBlueprint(InventoryPlayer player, CraftingProgressContainer.CraftInfo craftInfo);
        void RemoveRequiredCraftItemsAndCurrency(CraftingProgressContainer.CraftInfo craftInfo);
        void GiveCraftReward(CraftingProgressContainer.CraftInfo craftInfo);

        Coroutine StartCoroutine(IEnumerator coroutine);
        void StopCoroutine(IEnumerator coroutine);
    }
}
