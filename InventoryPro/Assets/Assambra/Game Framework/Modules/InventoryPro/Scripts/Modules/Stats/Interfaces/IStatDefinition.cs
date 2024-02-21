using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro.UI;
using UnityEngine;

namespace Assambra.InventoryPro
{
    public interface IStatDefinition : IEquatable<IStatDefinition>
    {
        string statName { get; }
        string category { get; }

        bool showInUI { get; }
        Sprite icon { get; }
        Color color { get; }
        StatRowUI uiPrefab { get; }

        string valueStringFormat { get; }
        float baseValue { get; }
        float maxValue { get; }

        int startLevel { get; }
        StatLevel[] levels { get; }

        string ToString(IStat stat);
        string ToString(IStat stat, string overrideFormat);
        string ToString(object value);
        string ToString(object value, string overrideFormat);
    }
}
