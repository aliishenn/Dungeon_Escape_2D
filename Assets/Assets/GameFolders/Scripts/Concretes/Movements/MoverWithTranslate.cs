using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;

namespace Dungeon_Escape_2D.Movements
{
    public class MoverWithTranslate : IMover
    {
        IEntityController _controller;
        
        float _moveSpeed;

        public MoverWithTranslate(IEntityController controller, float moveSpeed)
        {
            _controller = controller;
            _moveSpeed = moveSpeed;
        }

        public void Tick(float horizontal)
        {
            if (horizontal == 0f) return;

            _controller.transform.Translate(Vector2.right * horizontal * Time.deltaTime * _moveSpeed);
        }
    }
}

