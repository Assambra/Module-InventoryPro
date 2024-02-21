using System;
using Assambra.General.Editors;
using Object = UnityEngine.Object;

namespace Assambra.InventoryPro.Editors
{
    [CustomObjectPicker(typeof(StatDefinition))]
    public class ItemPropertyObjectPickerEditor : InventoryProObjectPickerBase
    {
        protected override string GetObjectName(Object asset)
        {
            var c = (StatDefinition)asset;
            return c.statName;
        }
    }
}
