using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using UnityEngine;

namespace Assambra.General
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HideInCreationWindowAttribute : Attribute
    {
        public HideInCreationWindowAttribute()
        {
        }
    }
}
