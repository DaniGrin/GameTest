using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModel :IScoreModel
{
    private int x = 0;
    public event Action ScoreChange;

    public ScoreModel(ButtonModel buttonModel)
    {
        buttonModel.Clicked += Increase;
    }

    

    public int GetCount()
    {
        return x;
    }

    public void Increase()
    {
        x++;
        CallChange();
    }

    private void CallChange()
    {
        ScoreChange?.Invoke();
    }
   
}
