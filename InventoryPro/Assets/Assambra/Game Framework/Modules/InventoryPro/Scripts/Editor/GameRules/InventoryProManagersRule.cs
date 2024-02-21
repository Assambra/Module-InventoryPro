using Assambra.General;
using Assambra.General.Editors.GameRules;
using UnityEngine;
using UnityEditor;

namespace Assambra.InventoryPro.Editors.GameRules
{
    public class InventoryProManagersRule : ManagersRuleBase
    {
        public override void UpdateIssue()
        {
            FindManagerOfTypeOrCreateIssue<InventoryManager>();
            FindManagerOfTypeOrCreateIssue<InventorySettingsManager>();
            FindManagerOfTypeOrCreateIssue<ItemManager>();
//            FindManagerOfTypeOrCreateIssue<InventoryPlayerManager>();
        }
    }
}