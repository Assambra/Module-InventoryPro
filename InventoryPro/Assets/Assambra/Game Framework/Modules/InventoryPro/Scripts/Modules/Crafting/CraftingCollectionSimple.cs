using System;
using System.Collections;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using Assambra.InventoryPro;
using UnityEngine;
using Assambra.InventoryPro.UI;
using UnityEngine.Assertions;

namespace Assambra.InventoryPro
{
    public partial class CraftingCollectionSimple : ItemCollectionBase
    {
        [SerializeField]
        private uint _initialCollectionSize;
        public override uint initialCollectionSize
        {
            get { return _initialCollectionSize; }
        }


        public override bool OverrideUseMethod(InventoryItemBase item)
        {
//            InventoryManager.AddItemAndRemove(item);
            return true;
        }
    }
}
