using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;

namespace Assambra.General.Localization
{
    public interface ILocalizedObject<T> : ILocalizedObject 
        where T: UnityEngine.Object
    {

        T val { get; set; }

    }

    public interface ILocalizedObject
    {
        UnityEngine.Object objectVal { get; set; }
    }
}
