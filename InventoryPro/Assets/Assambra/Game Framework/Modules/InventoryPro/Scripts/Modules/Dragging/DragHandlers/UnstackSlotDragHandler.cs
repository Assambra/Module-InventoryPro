using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assambra.InventoryPro.UI
{
    public class UnstackSlotDragHandler : StandardSlotDragHandler
    {

        public UnstackSlotDragHandler(int priority)
            : base(priority)
        {
            dragModel = new UIDragModel();
        }

        public override bool CanUse(ItemCollectionSlotUIBase wrapper, PointerEventData eventData)
        {
            return InventorySettingsManager.instance.settings.unstackKeys.AllPressed(eventData, InventoryActionInput.EventType.All);
        }
    }
}