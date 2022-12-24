using System.Collections;
using System.Collections.Generic;
using TMPro;
using Dungeon_Escape_2D.Abstracts.Combats;
using Dungeon_Escape_2D.Controllers;
using Dungeon_Escape_2D.Managers;
using UnityEngine;

namespace Dungeon_Escape_2D.Uis
{
    public class QuestionPanel : MonoBehaviour
    {
        [SerializeField] ResultPanel resultPanel;

        TextMeshProUGUI _messageText;
        int _lifeCount;
        IHealth _playerHealth;

        private void Awake()
        {
            _messageText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        }

        private void OnDisable()
        {
            _lifeCount = 0;
            _playerHealth = null;
        }

        public void SetLifeCountAndReferences(int lifeCount, IHealth playerHealth)
        {
            _lifeCount = lifeCount;
            _messageText.text = $"Do you want buy {_lifeCount} life?";
            _playerHealth = playerHealth;
        }

        public void YesClick()
        {
            resultPanel.gameObject.SetActive(true);

            if (_lifeCount <= GameManager.Instance.Score)
            {
                resultPanel.SetResultMessage($"You have bouht {_lifeCount} life have a good day...");
                GameManager.Instance.DecreaseScore(_lifeCount);
                _playerHealth.Heal(_lifeCount);
            }
            else
            {
                resultPanel.SetResultMessage("You do not have enouth diamond please try again later");
            }

            this.gameObject.SetActive(false);
        }
    }
}

