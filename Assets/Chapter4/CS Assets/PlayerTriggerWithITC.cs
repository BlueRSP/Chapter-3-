using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Panyawut.GameDev3.Chapter1;
using Panyawut.GameDev3.Chapter4;
using UnityEngine;

namespace Panyawut.GameDev3.Chapter4
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            ItemTypeComponent itc = other.GetComponent<ItemTypeComponent>();

            var inventory = GetComponent<Inventory>();

            var simpleHP = GetComponent<SimpleHealthPointComponent>();

            if (itc != null)
            {
                switch (itc.Type)
                {
                    case ItemType.COIN:
                        inventory.AddItem("COIN", 1);
                        break;
                    case ItemType.BIGCOIN:
                        inventory.AddItem("BIGCOIN", 1);
                        break;
                    case ItemType.POWERUP:
                        if (simpleHP != null)
                            simpleHP.HealthPoint = simpleHP.HealthPoint + 10;
                        break;
                    case ItemType.POWERDOWN:
                        if (simpleHP != null)
                            simpleHP.HealthPoint = simpleHP.HealthPoint - 10;
                        break;
                }
            }

            Destroy(other.gameObject, 0);
        }
    }
}