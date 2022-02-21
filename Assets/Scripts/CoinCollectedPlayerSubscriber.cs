using System;
using System.Collections;
using System.Collections.Generic;
using PubSub;
using UnityEngine;

namespace PubSub
{
    public class CoinCollectedPlayerSubscriber : MonoBehaviour, ISubscriber
    {
        private Player _playerComponent;
        
        private void Start()
        {
            _playerComponent = GetComponent<Player>();
            
            PubSub.Subscribe(this, typeof(CoinCollectedMessage));
        }

        public void OnPublish(IMessage message)
        {
            if (message.GetType() != typeof(CoinCollectedMessage)) return;

            _playerComponent.Score++;
        }
    }
}