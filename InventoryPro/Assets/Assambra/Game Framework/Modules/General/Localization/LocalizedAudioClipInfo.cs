using System;
using Assambra.General.Localization;
using UnityEngine;

namespace Assambra.General
{
    [Serializable]
    public class LocalizedAudioClipInfo
    {
        public LocalizedAudioClip audioClip;
        public float volume = 1f;
        public float pitch = 1f;
        public bool loop = false;
    }
}
