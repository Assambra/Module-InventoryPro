using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using Assambra.General.Editors;
using EditorStyles = Assambra.General.Editors.EditorStyles;

namespace Assambra.InventoryPro.Editors
{
    [CustomEditor(typeof(CraftingWindowStandardUI), true)]
    public class CraftingWindowStandardUIEditor : InventoryEditorBase
    {
        private SerializedProperty _startCraftingCategory;

        public override void OnEnable()
        {
            base.OnEnable();

            if (target == null)
                return;

            _startCraftingCategory = serializedObject.FindProperty("_startCraftingCategory");
        }

        protected override void OnCustomInspectorGUI(params CustomOverrideProperty[] extraSpecific)
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(script);

            GUILayout.Label("Behavior", EditorStyles.titleStyle);
            ObjectPickerUtility.RenderObjectPickerForType<CraftingCategory>(_startCraftingCategory);

            DrawPropertiesExcluding(serializedObject, new string[]
            {
                "m_Script",
                _startCraftingCategory.name,
            });

            serializedObject.ApplyModifiedProperties();
        }
    }
}