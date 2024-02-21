using UnityEngine;
using UnityEditor;
using System;

namespace Assambra.InventoryPro.Editors
{
    [CustomEditor(typeof(ItemDatabase), true)]
    public class ItemDatabaseEditor : Editor
    {
        public override void OnInspectorGUI()
        {

            DrawDefaultInspector();

            if (GUILayout.Button("Open editor"))
            {
                ItemManager.itemDatabaseLookup.SetDatabaseTemp((ItemDatabase) target);
                InventoryMainEditor.ShowWindow();
            }
        }
    }
}