using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Enums;
using Dungeon_Escape_2D.Managers;
using UnityEngine;

namespace Dungeon_Escape_2D.Uis
{
    /// <summary>
    /// Menu panel icindeki ButtonObjects ait bir component'tir bu component'in amaci icinde Menu start ve quit methodlari icin yazilmistir
    /// </summary>
    public class MenuButtonObject : MonoBehaviour
    {
        public void StartGame()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Game);
        }

        public void QuitGame()
        {
            GameManager.Instance.QuitGame();
        }
    }
}

