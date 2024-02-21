using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assambra.General.Localization
{
    [System.Serializable]
    public class LocalizedTexture2D : LocalizedObjectBase<Texture2D>
    {
        public LocalizedTexture2D()
        {

        }

        public LocalizedTexture2D(string key)
            : base(key)
        {

        }
    }
}
