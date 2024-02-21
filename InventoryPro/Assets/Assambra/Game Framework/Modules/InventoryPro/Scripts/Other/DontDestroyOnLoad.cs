using UnityEngine;
using System.Collections;

namespace Assambra.InventoryPro
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        public void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}