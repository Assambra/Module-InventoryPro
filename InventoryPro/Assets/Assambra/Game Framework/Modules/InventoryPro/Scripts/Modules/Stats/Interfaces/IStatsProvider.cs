using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;
using Assambra.InventoryPro;

namespace Assambra.InventoryPro
{
    public interface IStatsProvider
    {

        /// <summary>
        /// Set the categories and properties, does not calculate anything.
        /// </summary>
        Dictionary<string, List<IStat>> Prepare();

    }
}
