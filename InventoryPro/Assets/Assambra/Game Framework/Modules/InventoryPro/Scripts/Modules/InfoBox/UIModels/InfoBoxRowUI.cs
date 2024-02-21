using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.General;
using Assambra.InventoryPro;

namespace Assambra.InventoryPro.UI
{
    /// <summary>
    /// A single row in the infobox.
    /// </summary>
    public partial class InfoBoxRowUI : MonoBehaviour, IPoolable
    {
        public UnityEngine.UI.Text title;
        public UnityEngine.UI.Text message;


        public void ResetStateForPool()
        {
            // Item has no specific states, no need to reset
        }
    }
}