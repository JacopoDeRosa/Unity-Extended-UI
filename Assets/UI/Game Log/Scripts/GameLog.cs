using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExtendedUI
{
    public class GameLog : MonoBehaviour
    {
        [SerializeField] private GameObject _messageContainer;
        [SerializeField] private Message _messageTemplate;

        public void LogMessagePermanent(string message, string sender)
        {
           var buffer = Instantiate(_messageTemplate, _messageContainer.transform);
           buffer.Create(message, sender);
        }

        public void LogMessage(string message, string sender, float lifeTime)
        {
            var buffer = Instantiate(_messageTemplate, _messageContainer.transform);
            buffer.Create(message, sender);
            Destroy(buffer.gameObject, lifeTime);
        }
    }
}
