using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonModel : IButtonModel
{
    public event Action Clicked;

    public void Click()
    {
        CallClicked();
    }
    private void CallClicked()
    {
        Clicked?.Invoke();
    }
}
