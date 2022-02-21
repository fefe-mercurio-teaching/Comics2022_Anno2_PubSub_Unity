using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PubSub
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private int score;

        public int Score
        {
            get => score;
            set
            {
                score = value;
                
                PubSub.Publish(new ScoreChangedMessage(score));
            }
        }
        
        #if UNITY_EDITOR
        void Reset()
        {
            tag = "Player";
        }
        #endif

        void Update()
        {
            float speedFactor = Time.deltaTime * speed;

            float horizontal = Input.GetAxis("Horizontal") * speedFactor;
            float vertical = Input.GetAxis("Vertical") * speedFactor;
            
            transform.Translate(horizontal, 0f ,vertical);
        }
    }
}