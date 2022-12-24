using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon_Escape_2D.Abstracts.Movements
{
    public interface IMover
    {
        void Tick(float horizontal);
    }
}

