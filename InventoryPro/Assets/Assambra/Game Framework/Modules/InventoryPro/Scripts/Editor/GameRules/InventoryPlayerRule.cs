using Assambra.General;
using Assambra.General.Editors.GameRules;
using UnityEngine;
using UnityEditor;

namespace Assambra.InventoryPro.Editors.GameRules
{
    public class InventoryPlayerRule : GameRuleBase
    {
        public override void UpdateIssue()
        {
            var players = Resources.FindObjectsOfTypeAll<InventoryPlayer>();
            foreach (var player in players)
            {
                CreateIssueIfMissingComponent<Player>(player.gameObject, "InventoryPlayer component is missing the general Player component.", MessageType.Warning);
            }
        }
    }
}