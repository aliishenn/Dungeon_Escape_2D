using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Combats;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;

namespace Dungeon_Escape_2D.Uis
{
    public class ShopGameObject : MonoBehaviour
    {
        [SerializeField] QuestionPanel questionPanel;
        [SerializeField] GameObject shop;

        IHealth _playerHealth;

        private void OnEnable()
        {
            _playerHealth = FindObjectOfType<PlayerController>().GetComponent<IHealth>();
        }

        private void OnDisable()
        {
            _playerHealth = null;
        }

        public void BuyLifeClick(int lifeCount)
        {
            questionPanel.gameObject.SetActive(true);
            questionPanel.SetLifeCountAndReferences(lifeCount,_playerHealth);
        }

        public void IsActiveShop(bool isActive)
        {
            shop.SetActive(isActive);
        }
    }
}

