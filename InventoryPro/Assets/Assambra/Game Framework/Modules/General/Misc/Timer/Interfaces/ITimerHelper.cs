using System;
using System.Collections.Generic;
using Assambra.General.ThirdParty.UniLinq;
using System.Text;

namespace Assambra.General
{
    public interface ITimerHelper : IDisposable
    {
//        void StopAllTimers();
        void StopTimer(int id);
        int StartTimer(float time, Action callbackContinous, Action callbackWhenTimeIsOver);
        int StartTimer(float time, Action callbackWhenTimeIsOver);
    }
}
