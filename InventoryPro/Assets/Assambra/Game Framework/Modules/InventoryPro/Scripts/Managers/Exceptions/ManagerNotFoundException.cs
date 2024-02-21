using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;

namespace Assambra.InventoryPro
{
    public class ManagerNotFoundException : Exception
    {

        public ManagerNotFoundException(string managerName)
            : base(managerName + " - Check the setup wizard to resolve the issue.")
        {
            
        }

    }
}
