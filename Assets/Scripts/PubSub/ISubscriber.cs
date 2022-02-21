using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PubSub
{
    public interface ISubscriber
    {
        void OnPublish(IMessage message);
    }
}