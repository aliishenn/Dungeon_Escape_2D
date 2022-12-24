using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Controllers;
using Dungeon_Escape_2D.Abstracts.Movements;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;

namespace Dungeon_Escape_2D.Movements
{
    public class MoverWithVelocity : IMover
    {
        Rigidbody2D _rigidbody2D;
        float _moveSpeed;

        public MoverWithVelocity(PlayerController playerController, float moveSpeed)
        {
            _rigidbody2D = playerController.GetComponent<Rigidbody2D>();
            _moveSpeed = moveSpeed;
        }

        public void Tick(float horizontal)
        {
            if (horizontal != 0f || _rigidbody2D.velocity != Vector2.zero)
            {
                _rigidbody2D.velocity = new Vector2(horizontal * _moveSpeed * Time.fixedDeltaTime, _rigidbody2D.velocity.y);
            }
        }
    }
}

