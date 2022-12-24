using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon_Escape_2D.Abstracts.StateMachines
{
    public interface IState
    {
        void Tick();
        void OnEnter();
        void OnExit();
    }
}

