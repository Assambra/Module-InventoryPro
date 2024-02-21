using UnityEngine;
using System.Collections;
using Assambra.General;

namespace Assambra.InventoryPro.Demo
{
    public class LoadLevel : MonoBehaviour
    {
        public void LoadALevel(string level)
        {
            SceneUtility.LoadScene(level);
        }
    }
}