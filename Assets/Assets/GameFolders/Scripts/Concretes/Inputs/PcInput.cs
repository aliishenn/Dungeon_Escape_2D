using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Inputs;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;

namespace Dungeon_Escape_2D.Inputs
{
    public class PcInput : IPlayerInput
    {
        public float Horizontal => Input.GetAxis("Horizontal"); //+1 -1
        public float Vertical => Input.GetAxis("Vertical");
        public bool JumpButtonDown => Input.GetButtonDown("Jump");
        public bool AttackButtonDown => Input.GetButtonDown("Fire1");
    }
}

