using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.General;

namespace Assambra.InventoryPro
{
    public interface ISelectableObjectInfo
    {
        string name { get; }
        float health { get; }
        float maxHealth { get; }
        
        float healthFactor { get; }
        bool useHealth { get; set; }

        void ChangeHealth(float changeBy, bool fireEvents = true);
    }
}
