using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;

namespace Dungeon_Escape_2D.Movements
{
    public class FlipWithTransform:IFlip
    {
        IEntityController _entity;

        public FlipWithTransform(IEntityController entity)
        {
            _entity = entity;
        }

        public void FlipCharacter(float direction)
        {
            if (direction == 0f) return;

            float mathValue = Mathf.Sign(direction);

            if(mathValue != _entity.transform.localScale.x)
            {
                _entity.transform.localScale = new Vector2(mathValue, 1f);
            }
        }
    }
}

