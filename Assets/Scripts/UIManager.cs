using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PubSub
{
    public class UIManager : MonoBehaviour, ISubscriber
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        
        void Start()
        {
            PubSub.Subscribe(this, typeof(ScoreChangedMessage));
        }
        
        public void OnPublish(IMessage message)
        {
            if (message.GetType() == typeof(ScoreChangedMessage))
            {
                ScoreChangedMessage scoreChangedMessage = (ScoreChangedMessage)message;
                
                scoreText.text = scoreChangedMessage.Score.ToString();
            }
        }
    }
}