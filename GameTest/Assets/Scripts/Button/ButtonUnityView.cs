using System;
using UnityEngine;

namespace Button
{
    public class ButtonUnityView : MonoBehaviour, IButtonView
    {
        [SerializeField] private UnityEngine.UI.Button _button;
        
        public event Action Clicked;

        private void Start()
        {
            _button.onClick.AddListener(CallClicked);
        }

        private void CallClicked()
        {
            Clicked?.Invoke();
        }
    }
}