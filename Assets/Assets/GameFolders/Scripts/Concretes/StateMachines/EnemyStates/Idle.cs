using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Animations;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Abstracts.StateMachines;
using UnityEngine;

namespace Dungeon_Escape_2D.StateMachines.EnemyStates
{
    public class Idle : IState
    {
        IMover _mover;
        IMyAnimation _animation;

        float _maxStandTime;
        float _currentStandTime = 0f;

        public bool IsIdle { get; private set; }

        public Idle(IMover mover,IMyAnimation animation)
        {
            _mover = mover;
            _animation = animation;
        }

        public void OnEnter()
        {
            IsIdle = true;
            _animation.MoveAnimation(0f);

            _maxStandTime = Random.Range(4f, 10f);
        }

        public void OnExit()
        {
            _currentStandTime = 0f;
        }

        public void Tick()
        {
            _mover.Tick(0f);

            _currentStandTime += Time.deltaTime;

            if (_currentStandTime > _maxStandTime)
            {
                IsIdle = false;
            }

            Debug.Log("Idle Tick");
        }
    }
}

