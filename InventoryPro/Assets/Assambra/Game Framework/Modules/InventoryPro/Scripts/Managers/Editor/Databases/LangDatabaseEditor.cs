using UnityEngine;
using UnityEditor;
using System;

namespace Assambra.InventoryPro.Editors
{
    [CustomEditor(typeof(LangDatabase), true)]
    public class LangDatabaseEditor : Editor
    {
        public override void OnInspectorGUI()
        {

            DrawDefaultInspector();

            if (GUILayout.Button("Open main editor"))
            {
                InventoryManager.langDatabaseLookup.SetDatabaseTemp((LangDatabase)target);
                InventoryMainEditor.ShowWindow();
            }
        }
    }
}