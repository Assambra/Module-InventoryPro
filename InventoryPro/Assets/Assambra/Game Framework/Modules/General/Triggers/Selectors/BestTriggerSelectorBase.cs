using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assambra.General
{
    public abstract class BestTriggerSelectorBase : ScriptableObject
    {
        public abstract TriggerBase GetBestTrigger(Player player, List<TriggerBase> triggersInRange);
    }
}
