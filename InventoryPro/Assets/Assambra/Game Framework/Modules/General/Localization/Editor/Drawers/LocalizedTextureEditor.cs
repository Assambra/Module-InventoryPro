using System;
using System.Reflection;
using Assambra.General.Editors.ReflectionDrawers;
using UnityEditor;
using UnityEngine;

namespace Assambra.General.Localization.Editors
{
    [CustomDrawer(typeof(LocalizedTexture2D))]
    public class LocalizedTextureDrawer : LocalizedObjectDrawerBase<Texture2D, LocalizedTexture2D>
    {
        public LocalizedTextureDrawer(FieldInfo fieldInfo, object value, object parentValue, int arrayIndex)
            : base(fieldInfo, value, parentValue, arrayIndex)
        {
        }

        public override DrawerBase FindDrawerRelative(string fieldName)
        {
            return null;
        }
    }
}
