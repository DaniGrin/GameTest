using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour, IScoreView
{
    [SerializeField] private Text _text;


    public void SetScore(int count)
    {
        _text.text = count.ToString();

    }
}
