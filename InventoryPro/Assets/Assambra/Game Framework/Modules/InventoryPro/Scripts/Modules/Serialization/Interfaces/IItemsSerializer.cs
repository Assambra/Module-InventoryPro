using System;
using System.Collections.Generic;
using Assambra.InventoryPro;

namespace Assambra.InventoryPro
{
    public interface IItemsSerializer
    {
        object SerializeCollection(ItemCollectionBase collection);
        object SerializeContainer(IInventoryItemContainer container);

        ItemCollectionSerializationModel DeserializeCollection(object serializedData);
        ItemContainerSerializationModel DeserializeContainer(object serializedData);
    }
}
