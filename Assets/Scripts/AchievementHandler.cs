using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PubSub
{
    public class AchievementHandler : MonoBehaviour, ISubscriber
    {
        private List<Achievement> _collectedAchievements = new List<Achievement>();

        private void Start()
        {
            PubSub.Subscribe(this, typeof(ScoreChangedMessage));
        }

        private void Unlock(Achievement achievement)
        {
            if (_collectedAchievements.Contains(achievement)) return;
            
            _collectedAchievements.Add(achievement);
            Debug.Log("Achievement: " + achievement);
        }

        public void OnPublish(IMessage message)
        {
            if (message is ScoreChangedMessage)
            {
                ScoreChangedMessage scoreChangedMessage = (ScoreChangedMessage)message;

                if (scoreChangedMessage.Score >= 5)
                {
                    Unlock(Achievement.FivePoints);
                }
            }
        }
    }
}