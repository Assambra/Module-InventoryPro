using System;
using System.Collections.Generic;
using Assambra.InventoryPro;
using UnityEngine;

namespace Assambra.InventoryPro
{
    public partial interface IInventoryItemContainerGenerator
    {
        IInventoryItemContainer container { get; }

        IItemGenerator generator { get; }
    }
}