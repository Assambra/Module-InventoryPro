using System;
using UnityEngine;
using UnityEditor;

namespace Assambra.General.Editors
{
    public class VerticalLayoutBlock : IDisposable
    {

        public VerticalLayoutBlock()
            : this(GUIStyle.none)
        { }

        public VerticalLayoutBlock(GUIStyle style)
        {
            EditorGUILayout.BeginVertical(style);
        }

        public void Dispose()
        {
            EditorGUILayout.EndVertical();
        }
    }
}