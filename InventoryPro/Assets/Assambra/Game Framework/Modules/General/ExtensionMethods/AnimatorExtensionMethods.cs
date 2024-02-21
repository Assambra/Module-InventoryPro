using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assambra.General
{
    public static class AnimatorExtensionMethods
    {
        public static void Play(this Animator animator, MotionInfo info)
        {
            if (info.motion == null)
            {
                return;
            }

            animator.speed = info.speed;
            if(info.crossFade)
            {
            	animator.CrossFade(info.motion.name, info.crossFadeSpeed);
            }
            else
            {
	            animator.Play(info.motion.name);
            }
        }
    }
}
