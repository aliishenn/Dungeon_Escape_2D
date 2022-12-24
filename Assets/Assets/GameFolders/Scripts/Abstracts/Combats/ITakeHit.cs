using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon_Escape_2D.Abstracts.Combats
{
    public interface ITakeHit
    {
        void TakeHit(IAttacker attacker);
    }
}

