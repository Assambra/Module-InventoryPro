using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;

namespace Assambra.InventoryPro
{
    public interface IEquippableCharacter : ICharacterStats
    {
        CharacterEquipmentTypeBinder[] equipmentBinders { get; set; }
        CharacterEquipmentHandlerBase equipmentHandler { get; }
    }
}
