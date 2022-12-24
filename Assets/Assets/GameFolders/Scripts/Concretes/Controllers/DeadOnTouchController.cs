using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Combats;
using UnityEngine;

namespace Dungeon_Escape_2D.Controllers
{
    public class DeadOnTouchController : MonoBehaviour
    {
        IAttacker _attacker;

        private void Awake()
        {
            _attacker = GetComponent<IAttacker>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            IHealth health = collision.GetComponent<IHealth>();

            if (health != null)
            {
                health.TakeHit(_attacker);
            }
        }
    }
}

