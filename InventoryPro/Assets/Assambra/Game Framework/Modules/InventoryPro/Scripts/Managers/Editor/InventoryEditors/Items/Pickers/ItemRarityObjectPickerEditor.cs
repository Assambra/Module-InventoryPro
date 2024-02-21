using System;
using Assambra.General.Editors;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assambra.InventoryPro.Editors
{
    [CustomObjectPicker(typeof(ItemRarity))]
    public class ItemRarityObjectPickerEditor : InventoryProObjectPickerBase
    {
        protected override string GetObjectName(Object asset)
        {
            var c = (ItemRarity)asset;
            return c.name;
        }

        protected override void DrawObject(Rect r, Object obj)
        {
            var rarity = (ItemRarity)obj;
            using (new ColorBlock(rarity.color))
            {
                base.DrawObject(r, obj);
            }
        }
    }
}
