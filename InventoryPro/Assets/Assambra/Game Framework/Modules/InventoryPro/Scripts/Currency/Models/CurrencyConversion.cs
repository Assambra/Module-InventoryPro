using System;
using System.Collections.Generic;
using Assambra.General;

namespace Assambra.InventoryPro
{
    [Serializable]
    public class CurrencyConversion
    {

        public float factor = 1.0f;

        [Required]
        public CurrencyDefinition currency;

        public bool useInAutoConversion = false;


    }
}
