using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;

namespace Dungeon_Escape_2D.Movements
{
    public class FlipWithSpriteRender : IFlip
    {
        SpriteRenderer _spriteRender;

        public FlipWithSpriteRender(PlayerController player)
        {
            _spriteRender = player.GetComponentInChildren<SpriteRenderer>();
        }

        public void FlipCharacter(float direction)
        {
            if (direction == 0f) return;

            if (direction < 0f)
            {
                _spriteRender.flipX = true;
            }
            else
            {
                _spriteRender.flipX = false;
            }
        }
    }
}

