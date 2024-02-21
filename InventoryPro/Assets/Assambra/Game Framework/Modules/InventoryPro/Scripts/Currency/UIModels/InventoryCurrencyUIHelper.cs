﻿using UnityEngine;
using System.Collections;

using Assambra.InventoryPro;

namespace Assambra.InventoryPro.UI
{
    using UnityEngine.UI;

    public class InventoryCurrencyUIHelper : MonoBehaviour
    {
        public uint currencyID;
        public bool allowCurrencyConversions = true;

        public ItemCollectionBase toCollection;
        public Button button;


        public void Awake()
        {
            if (button != null)
            {
                button.onClick.AddListener(() =>
                {
                    TriggerAddCurrencyToCollection(toCollection);
                });
            }
        }

        public void TriggerAddCurrencyToCollection(ItemCollectionBase collection)
        {
            InventoryManager.instance.intValDialog.ShowDialog(transform, "Amount", "", 1, 9999, value =>
            {
                // Yes callback
                if (InventoryManager.CanRemoveCurrency(currencyID, (float)value, allowCurrencyConversions))
                {
                    InventoryManager.RemoveCurrency(currencyID, value);
                    toCollection.AddCurrency(currencyID, value);
                }

            }, value =>
            {
                // No callback

            }
            );
        }
    }
}
