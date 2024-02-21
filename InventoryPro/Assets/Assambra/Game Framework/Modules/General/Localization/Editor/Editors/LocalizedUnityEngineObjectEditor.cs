using System;
using UnityEditor;

namespace Assambra.General.Localization.Editors
{
    [CustomPropertyDrawer(typeof(LocalizedObject), true)]
    public class LocalizedUnityEngineObjectEditor : LocalizedObjectEditorBase<UnityEngine.Object, LocalizedObject>
    {
        
    }
}
