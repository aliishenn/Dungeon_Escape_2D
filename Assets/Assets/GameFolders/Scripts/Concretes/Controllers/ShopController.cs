using System.Collections;
using System.Collections.Generic;
using Dungeon_Escape_2D.Uis;
using UnityEngine;

namespace Dungeon_Escape_2D.Controllers
{
    public class ShopController : MonoBehaviour
    {
        ShopGameObject _shopGameObject;

        private void Start()
        {
            _shopGameObject = FindObjectOfType<ShopGameObject>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            IsPlayerTriggered(collision, true);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            IsPlayerTriggered(collision,false);
        }

        private void IsPlayerTriggered(Collider2D collider,bool isActive)
        {
            PlayerController player = collider.GetComponent<PlayerController>();

            if (player != null)
            {
                _shopGameObject.IsActiveShop(isActive);
            }
        }
    }
}

