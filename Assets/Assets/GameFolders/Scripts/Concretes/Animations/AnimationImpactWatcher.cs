using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon_Escape_2D.Animations
{
    public class AnimationImpactWatcher : MonoBehaviour
    {
        public event System.Action OnImpact;

        public void Impact()
        {
            OnImpact?.Invoke();
        }
    }
}

