using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ExtendedUI
{
    public class LogInput : MonoBehaviour
    {
        [SerializeField] private string _senderName;
        [SerializeField] private GameLog _log;
        [SerializeField] private InputField _inputField;
        [SerializeField] private float _messageLifeTime = 10;

        public void Message(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            _log.LogMessage(text, _senderName, _messageLifeTime);
            _inputField.text = "";
        }

        public void SetSenderName(string name)
        {
            _senderName = name;
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
             _inputField.ActivateInputField();
            }
        }

    }
}
