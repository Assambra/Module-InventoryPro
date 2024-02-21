using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro;

namespace Assambra.InventoryPro.UI
{
    public partial class UIDragModel
    {
        public int startIndex = -1;
        public ItemCollectionBase startItemCollection;

        public int endIndex = -1;
        public ItemCollectionBase endItemCollection;

        public bool endOnSlot
        {
            get
            {
                return endItemCollection != null;
            }
        }


        public void Reset()
        {
            startIndex = -1;
            startItemCollection = null;

            endIndex = -1;
            endItemCollection = null;
        }
    }
}
