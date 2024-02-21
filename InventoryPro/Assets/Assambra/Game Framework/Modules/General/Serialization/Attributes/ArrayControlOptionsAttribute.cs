using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using UnityEngine;

namespace Assambra.General
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ArrayControlOptionsAttribute : Attribute
    {
//        public bool includeArrayChildren { get; protected set; }
        public bool canRemoveItems = true;
        public bool canAddItems = true;

        public ArrayControlOptionsAttribute()
        {
        }
    }
}
