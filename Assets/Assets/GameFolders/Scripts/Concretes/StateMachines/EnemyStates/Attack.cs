using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Animations;
using Dungeon_Escape_2D.Abstracts.Combats;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Abstracts.StateMachines;
using UnityEngine;

namespace Dungeon_Escape_2D.StateMachines.EnemyStates
{
    public class Attack : IState
    {
        IMyAnimation _animation;
        IAttacker _attacker;
        IHealth _playerHealth;
        IFlip _flip;
        System.Func<bool> _isPlayerRightSide;

        float _currentAttackTime;
        float _maxAttackTime;

        public Attack(IHealth playerHealth,IFlip flip, IMyAnimation animation, IAttacker attacker, float maxAttackTime, System.Func<bool> isPlayerRightSide)
        {
            _flip = flip;
            _animation = animation;
            _attacker = attacker;
            _playerHealth = playerHealth;
            _maxAttackTime = maxAttackTime;
            _isPlayerRightSide = isPlayerRightSide;
        }

        public void OnEnter()
        {
            _currentAttackTime = 0f;
        }

        public void OnExit()
        {

        }

        public void Tick()
        {
            _currentAttackTime += Time.deltaTime;

            if (_currentAttackTime > _maxAttackTime)
            {
                _flip.FlipCharacter(_isPlayerRightSide.Invoke() ? 1f : -1f);
                _animation.AttackAnimation();
                _attacker.Attack(_playerHealth);
                _currentAttackTime = 0f;
            }

            Debug.Log("Attack Tick");
        }
    }
}

