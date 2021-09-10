using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScoreModel
{
    event Action ScoreChange;
    int GetCount();

    void Increase();

}
