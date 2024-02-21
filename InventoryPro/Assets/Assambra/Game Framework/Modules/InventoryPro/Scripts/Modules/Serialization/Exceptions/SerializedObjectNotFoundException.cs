using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;

namespace Assambra.InventoryPro
{
    public class SerializedObjectNotFoundException : Exception
    {

        public SerializedObjectNotFoundException(string message)
            : base(message)
        {
            
        }
    }
}
