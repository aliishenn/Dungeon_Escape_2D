using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon_Escape_2D.Abstracts.Animations
{
    public interface IMyAnimation
    {
        void MoveAnimation(float moveSpeed);
        void JumpAnimation(bool isJump);
        void AttackAnimation();
        void TakeHitAnimation();
        void DeadAnimation();
    }
}

