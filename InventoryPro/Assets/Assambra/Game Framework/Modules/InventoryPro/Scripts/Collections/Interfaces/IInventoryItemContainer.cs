using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using UnityEngine;

namespace Assambra.InventoryPro
{
    public interface IInventoryItemContainer
    {
        string uniqueName { get; }

        InventoryItemBase[] items { get; set; }
    }
}
