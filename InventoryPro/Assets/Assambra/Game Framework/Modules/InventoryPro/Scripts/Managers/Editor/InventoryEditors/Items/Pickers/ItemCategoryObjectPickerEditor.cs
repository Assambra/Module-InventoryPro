using System;
using Assambra.General.Editors;
using Object = UnityEngine.Object;

namespace Assambra.InventoryPro.Editors
{
    [CustomObjectPicker(typeof(ItemCategory))]
    public class ItemCategoryObjectPickerEditor : InventoryProObjectPickerBase
    {
        protected override string GetObjectName(Object asset)
        {
            var c = (ItemCategory)asset;
            return c.name;
        }
    }
}
