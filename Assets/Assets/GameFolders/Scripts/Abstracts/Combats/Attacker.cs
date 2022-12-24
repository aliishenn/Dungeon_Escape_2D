using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Combats;
using UnityEngine;

namespace Dungeon_Escape_2D.Abstracts.Combats
{
    public abstract class Attacker : MonoBehaviour,IAttacker
    {
        [SerializeField] int damage = 1;

        public int Damage => damage;

        public virtual void Attack(ITakeHit takeHit)
        {
            takeHit.TakeHit(this);
        }
    }
}

