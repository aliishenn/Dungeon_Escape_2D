using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Animations;
using Dungeon_Escape_2D.Abstracts.Combats;
using Dungeon_Escape_2D.Abstracts.StateMachines;
using UnityEngine;

namespace Dungeon_Escape_2D.StateMachines.EnemyStates
{
    public class TakeHit : IState
    {
        readonly IMyAnimation _animation;

        float _maxDelayTime = 0.3f;
        float _currentDelayTime = 0f;

        public bool IsTakeHit { get; private set; }

        public TakeHit(IHealth health, IMyAnimation animation)
        {
            _animation = animation;
            health.OnHealthChanged += (currentHealth, maxHealth) => OnEnter();
        }

        public void OnEnter()
        {
            IsTakeHit = true;
            _animation.TakeHitAnimation();
        }

        public void OnExit()
        {
            _currentDelayTime = 0f;
        }

        public void Tick()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > _maxDelayTime && IsTakeHit)
            {
                IsTakeHit = false;
            }

            Debug.Log("Take Hit Tick");
        }
    }
}