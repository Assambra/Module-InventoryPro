using System;
using UnityEngine;

namespace Assambra.General
{
    public class DestroyAfterSeconds : MonoBehaviour
    {
        public float seconds = 1f;

        protected void Awake()
        {
            Destroy(gameObject, seconds);
        }
    }
}
