﻿using System;
using Assambra.General.UI;
using UnityEngine;

namespace Assambra.General.UI
{
    [System.Serializable]
    public class UIWindowField : UIWindowField<UIWindow>
    { }

    [System.Serializable]
    public class UIWindowField<T> where T : UIWindow
    {
        public bool useDynamicSearch = false;
        public string name;

        [SerializeField]
        private T _window;
        public T window
        {
            get
            {
                if (_window == null && useDynamicSearch)
                {
                    _window = UIWindowUtility.FindByName<T>(name);
                }

                return _window;
            }
            set { _window = value; }
        }
    }
}