using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Animations;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Abstracts.StateMachines;
using UnityEngine;

namespace Dungeon_Escape_2D.StateMachines.EnemyStates
{
    public class ChasePlayer : IState
    {
        IMover _mover;
        IFlip _flip;
        IMyAnimation _animation;
        IStopEdge _stopEdge;
        System.Func<bool> _isPlayerRightSide;

        public ChasePlayer(IMover mover, IFlip flip, IMyAnimation animation,IStopEdge stopEdge, System.Func<bool> isPlayerRightSide)
        {
            _mover = mover;
            _flip = flip;
            _animation = animation;
            _stopEdge = stopEdge;
            _isPlayerRightSide = isPlayerRightSide;
        }

        public void OnEnter()
        {
            _animation.MoveAnimation(1f);
        }

        public void OnExit()
        {
            _animation.MoveAnimation(0f);
        }

        public void Tick()
        {
            if (_stopEdge.ReachEdge())
            {
                if (_stopEdge.IsRightDirection && !_isPlayerRightSide.Invoke())
                {
                    ChaseAgain(-1.5f,-1f,1f);
                    return;
                }
                else if(!_stopEdge.IsRightDirection && _isPlayerRightSide.Invoke())
                {
                    ChaseAgain(1.5f,1f,1f);
                    return;
                }
                
                _animation.MoveAnimation(0f);
                return;
            }

            if (_isPlayerRightSide.Invoke())
            {
                _mover.Tick(1.5f);
                _flip.FlipCharacter(1f);
            }
            else
            {
                _mover.Tick(-1.5f);
                _flip.FlipCharacter(-1f);
            }
        }

        private void ChaseAgain(float moveDirection, float flipDirection, float animationSpeed)
        {
            _mover.Tick(moveDirection);
            _flip.FlipCharacter(flipDirection);
            _animation.MoveAnimation(animationSpeed);
        }
    }
}

