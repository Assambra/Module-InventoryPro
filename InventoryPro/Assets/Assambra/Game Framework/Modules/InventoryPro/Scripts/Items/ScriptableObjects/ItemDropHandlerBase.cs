using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.General;
using UnityEngine;

namespace Assambra.InventoryPro
{
    public abstract class ItemDropHandlerBase : ScriptableObject
    {

        public abstract GameObject DropItem(InventoryItemBase item);
        public abstract GameObject DropItem(InventoryItemBase item, Vector3 position, Quaternion rotation);
        public abstract Vector3? CalculateDropPosition(InventoryItemBase item);

    }
}
