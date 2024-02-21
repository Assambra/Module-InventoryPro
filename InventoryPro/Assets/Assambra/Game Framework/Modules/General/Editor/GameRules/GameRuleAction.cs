using System;
using System.Collections.Generic;

namespace Assambra.General.Editors.GameRules
{
    public class GameRuleAction
    {
        public System.Action action;
        public string name;

        public GameRuleAction(string name, System.Action action)
        {
            this.name = name;
            this.action = action;
        }
    }
}
