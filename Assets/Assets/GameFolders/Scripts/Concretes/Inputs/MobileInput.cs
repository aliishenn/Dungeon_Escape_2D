using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Inputs;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Dungeon_Escape_2D.Inputs
{
    public class MobileInput : IPlayerInput
    {
        public float Horizontal => CrossPlatformInputManager.GetAxis("Horizontal");

        public float Vertical => CrossPlatformInputManager.GetAxis("Vertical");

        public bool JumpButtonDown => CrossPlatformInputManager.GetButtonDown("Jump");

        public bool AttackButtonDown => CrossPlatformInputManager.GetButtonDown("Fire1");
    }
}

