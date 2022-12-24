using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Enums;
using Dungeon_Escape_2D.Managers;
using UnityEngine;

namespace Dungeon_Escape_2D.Controllers
{
    public class CanvasSceneController : MonoBehaviour
    {
        [SerializeField] SceneTypeEnum sceneType;
        [SerializeField] GameObject canvasObject;

        private void Start()
        {
            GameManager.Instance.OnSceneChanged += HandleSceneChanged;
        }

        private void OnDestroy()
        {
            GameManager.Instance.OnSceneChanged -= HandleSceneChanged;
        }

        private void HandleSceneChanged(SceneTypeEnum sceneType)
        {
            if (sceneType == this.sceneType)
            {
                canvasObject.SetActive(true);
            }
            else
            {
                canvasObject.SetActive(false);
            }
        }
    }
}

