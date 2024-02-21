using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro;

namespace Assambra.InventoryPro
{
    public class CollectionAvoidRebuildLock : IDisposable
    {
        public ItemCollectionBase[] collections { get; set; }

        public CollectionAvoidRebuildLock(params ItemCollectionBase[] collections)
        {
            this.collections = collections;
            foreach (var col in this.collections)
            {
                col.disableCounterRebuildBlocks++;
            }
        }

        public void Dispose()
        {
            foreach (var col in this.collections)
            {
                col.disableCounterRebuildBlocks--;
            }
        }
    }
}
