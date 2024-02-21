using System;
using Assambra.General.Editors;
using Object = UnityEngine.Object;

namespace Assambra.InventoryPro.Editors
{
    [CustomObjectPicker(typeof(CurrencyDefinition))]
    public class CurrencyObjectPickerEditor : InventoryProObjectPickerBase
    {
        public override bool IsSearchMatch(Object asset, string searchQuery)
        {
            var c = (CurrencyDefinition)asset;
            searchQuery = searchQuery.ToLower();

            return c.singleName.ToLower().Contains(searchQuery) ||
                   c.pluralName.ToLower().Contains(searchQuery) ||
                   asset.GetType().Name.ToLower().Contains(searchQuery);
        }

        protected override string GetObjectName(Object asset)
        {
            var c = (CurrencyDefinition)asset;
            return c.singleName;
        }
    }
}
