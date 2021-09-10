using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonview : MonoBehaviour, Ibuttonview
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
