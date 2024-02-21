using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using UnityEngine;

namespace Assambra.InventoryPro
{
    public abstract class CollectionSorterBase : ScriptableObject
    {

        public abstract IList<InventoryItemBase> Sort(IList<InventoryItemBase> items);

    }
}
