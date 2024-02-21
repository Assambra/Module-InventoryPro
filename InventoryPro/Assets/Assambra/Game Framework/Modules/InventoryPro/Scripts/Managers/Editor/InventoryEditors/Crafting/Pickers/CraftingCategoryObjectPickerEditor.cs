using System;
using Assambra.General.Editors;
using Object = UnityEngine.Object;

namespace Assambra.InventoryPro.Editors
{
    [CustomObjectPicker(typeof(CraftingCategory))]
    public class CraftingCategoryObjectPickerEditor : InventoryProObjectPickerBase
    {
        protected override string GetObjectName(Object asset)
        {
            var c = (CraftingCategory)asset;
            return c.name;
        }
    }
}
