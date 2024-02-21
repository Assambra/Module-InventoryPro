using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro;

namespace Assambra.General
{
    public partial class Player
    {

        private InventoryPlayer _inventoryPlayer;
        public InventoryPlayer inventoryPlayer
        {
            get
            {
                if (_inventoryPlayer == null)
                {
                    _inventoryPlayer = GetComponent<InventoryPlayer>();
                }

                return _inventoryPlayer;
            }
        }

    }
}
