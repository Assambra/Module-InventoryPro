using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assambra.General.Localization.Editors
{
    [CustomPropertyDrawer(typeof(LocalizedAudioClip), true)]
    public class LocalizedAudioClipEditor : LocalizedObjectEditorBase<AudioClip, LocalizedAudioClip>
    {
        
    }
}
