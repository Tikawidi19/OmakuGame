using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class item : MonoBehaviour
{
    //public string itemname;

    public Vector2 anchoredPosition { get; internal set; }
    public databahan databahan;
    public TMP_Text nameText;
    public Image Image;
    public string itemname;

    void Start()
    {
        //nameText.text = databahan.namabahan;
        Image.sprite = databahan.imag;       
    }
}
