using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.General.UI;
using UnityEngine;

namespace Assambra.General
{
    public static class TriggerUtility
    {
        public static TriggerBase mouseOnTrigger { get; set; }
        public static bool isMouseOnTrigger
        {
            get { return mouseOnTrigger != null; }
        }
    }
}
