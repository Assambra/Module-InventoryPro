using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;

namespace Assambra.InventoryPro
{
    public class DatabaseNotFoundException : Exception
    {

        public DatabaseNotFoundException(string msg)
            : base(msg)
        {
            
        }

    }
}
