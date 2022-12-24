using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Combats;
using UnityEngine;

namespace Dungeon_Escape_2D.Uis
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        IHealth _playerHealth;

        private void OnEnable()
        {
            gameOverPanel.SetActive(false);
        }

        public void SetPlayerHealth(IHealth health)
        {
            _playerHealth = health;
            _playerHealth.OnDead += HandleDead;
        }

        private void HandleDead()
        {
            gameOverPanel.SetActive(true);
            _playerHealth.OnDead -= HandleDead;
            _playerHealth = null;
        }
    }
}

