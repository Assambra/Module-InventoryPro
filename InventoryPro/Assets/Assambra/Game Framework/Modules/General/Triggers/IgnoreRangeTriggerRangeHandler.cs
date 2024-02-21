using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using UnityEngine.Assertions;

namespace Assambra.General
{
    public partial class IgnoreRangeTriggerRangeHandler : MonoBehaviour, ITriggerRangeHandler
    {
        public IEnumerable<Player> GetPlayersInRange()
        {
            return new Player[0];
        }

        public bool IsPlayerInRange(Player target)
        {
            return true;
        }
    }
}