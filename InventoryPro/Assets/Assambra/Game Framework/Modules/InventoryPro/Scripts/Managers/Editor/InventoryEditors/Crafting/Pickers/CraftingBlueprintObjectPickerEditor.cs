using System;
using Assambra.General.Editors;
using Object = UnityEngine.Object;

namespace Assambra.InventoryPro.Editors
{
    [CustomObjectPicker(typeof(CraftingBlueprint))]
    public class CraftingBlueprintObjectPickerEditor : InventoryProObjectPickerBase
    {
        protected override string GetObjectName(Object asset)
        {
            var c = (CraftingBlueprint)asset;
            return c.name;
        }
    }
}
