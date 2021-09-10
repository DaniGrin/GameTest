using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour, ITextView
{
    [SerializeField] private Text _text;

    public int count { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void setClicks(int count)
    {
        


    }
}
