using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IButtonModel 
{
    event Action Clicked;
    void Click();
}
