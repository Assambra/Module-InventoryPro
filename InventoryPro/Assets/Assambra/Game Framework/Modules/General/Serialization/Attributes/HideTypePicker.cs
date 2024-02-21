using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using UnityEngine;

namespace Assambra.General
{
    [AttributeUsage(AttributeTargets.Field)]
    public class HideTypePicker : Attribute
    {

        public HideTypePicker()
        {
        }
    }
}
