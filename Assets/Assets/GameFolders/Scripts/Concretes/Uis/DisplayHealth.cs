using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Abstracts.Combats;
using Dungeon_Escape_2D.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Dungeon_Escape_2D.Uis
{
    public class DisplayHealth : MonoBehaviour
    {
        Image _healthImage;
        IHealth _health;

        private void Awake()
        {
            _healthImage = GetComponent<Image>();
        }

        private void OnEnable()
        {
            _health = FindObjectOfType<PlayerController>().GetComponent<IHealth>();
            _health.OnHealthChanged += HandleHealthChanged;
        }

        private void OnDisable()
        {
            _health.OnHealthChanged -= HandleHealthChanged;
            _healthImage.fillAmount = 1f;
        }

        private void HandleHealthChanged(int currentHealth, int maxHealth)
        {
            _healthImage.fillAmount = (float)currentHealth / (float)maxHealth;
        }
    }
}

