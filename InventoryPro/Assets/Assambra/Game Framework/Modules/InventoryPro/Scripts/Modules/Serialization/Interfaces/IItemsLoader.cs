using System;
using System.Collections.Generic;
using Assambra.InventoryPro;

namespace Assambra.InventoryPro
{
    public interface IItemsLoader
    {
        void LoadItems(Action<object> callback);
    }
}