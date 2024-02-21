using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using Assambra.General;


namespace Assambra.InventoryPro
{
    public partial class ExtendedInventoryItemSerializationModel : InventoryItemSerializationModel
    {
        public override void FromItem(InventoryItemBase item)
        {
            UnityEngine.Debug.Log("From extended...");
            base.FromItem(item);
        }

        public override InventoryItemBase ToItem()
        {
            UnityEngine.Debug.Log("From extended...");
            return base.ToItem();
        }
    }
}
