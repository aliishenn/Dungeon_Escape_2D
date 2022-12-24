using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon_Escape_2D.Abstracts.Combats
{
    public interface IAttacker
    {
        void Attack(ITakeHit takeHit);
        int Damage { get; }
    }
}

