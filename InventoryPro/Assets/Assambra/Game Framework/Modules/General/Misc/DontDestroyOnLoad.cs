using System;
using UnityEngine;

namespace Assambra.General
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        protected void Start()
        {
            DontDestroyOnLoad(this);
        }
    }
}
