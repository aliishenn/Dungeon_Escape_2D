using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Enums;
using Dungeon_Escape_2D.Managers;
using UnityEngine;

namespace Dungeon_Escape_2D.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Game);
        }

        public void NoButton()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Menu);
        }
    }
}

