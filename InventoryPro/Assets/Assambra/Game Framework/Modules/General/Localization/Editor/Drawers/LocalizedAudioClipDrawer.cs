using System;
using System.Reflection;
using Assambra.General.Editors.ReflectionDrawers;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assambra.General.Localization.Editors
{
    [CustomDrawer(typeof(LocalizedAudioClip))]
    public class LocalizedAudioClipDrawer : LocalizedObjectDrawerBase<AudioClip, LocalizedAudioClip>
    {
        public LocalizedAudioClipDrawer(FieldInfo fieldInfo, object value, object parentValue, int arrayIndex)
            : base(fieldInfo, value, parentValue, arrayIndex)
        {
        }

        public override DrawerBase FindDrawerRelative(string fieldName)
        {
            return null;
        }
    }
}
