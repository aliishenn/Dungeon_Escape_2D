using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Animations;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.StateMachines;
using UnityEngine;

namespace Dungeon_Escape_2D.StateMachines.EnemyStates
{
    public class Dead : IState
    {
        IMyAnimation _animation;
        IEntityController _controller;
        System.Action _deadCallback;

        float _currentTime = 0f;

        public Dead(IEntityController controller,IMyAnimation animation, System.Action deadCallback)
        {
            _controller = controller;
            _animation = animation;
            _deadCallback = deadCallback;
        }

        public void OnEnter()
        {
            _animation.DeadAnimation();
            _deadCallback?.Invoke();
        }

        public void OnExit()
        {
            _currentTime = 0f;
        }

        public void Tick()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > 5f)
            {
                Object.Destroy(_controller.transform.gameObject);
            }

            Debug.Log("Dead Tick");
        }
    }
}

