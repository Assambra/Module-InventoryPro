using System;
using UnityEngine;
using System.Collections;
using Assambra.General;

namespace Assambra.InventoryPro
{
    [System.Serializable]
    public partial class ItemRarity : ScriptableObject
    {
        public uint ID;

        [Required]
        public new string name;
        public Color color = Color.white;

        /// <summary>
        /// The item that is used when dropping something, leave null to use the object model itself.
        /// </summary>
        [Tooltip("The item that is used when dropping something, leave null to use the object model itself.")]
        public GameObject dropObject;
    }
}