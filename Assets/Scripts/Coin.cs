using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PubSub
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;

            PubSub.Publish(new CoinCollectedMessage());
            
            Destroy(gameObject);
        }
    }
}