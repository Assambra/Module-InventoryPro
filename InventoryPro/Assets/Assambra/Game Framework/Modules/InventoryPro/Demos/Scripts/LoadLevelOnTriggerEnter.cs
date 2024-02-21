using UnityEngine;
using System.Collections;
using Assambra.General;

namespace Assambra.InventoryPro.Demo
{
    public class LoadLevelOnTriggerEnter : MonoBehaviour
    {
        public string levelToLoad;


        public void OnTriggerEnter(Collider col)
        {
            LoadLevel();
        }


        public void LoadLevel()
        {
            SceneUtility.LoadScene(levelToLoad);
        }
    }
}