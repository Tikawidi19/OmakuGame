using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace inventory.UI
{
    public class UIInventoryDescription : MonoBehaviour
{
    [SerializeField]
    private Image itemImage;
    [SerializeField]
    private TMP_Text title;
    [SerializeField] 
    private TMP_Text describtion;

    public void Awake() {
        ResetDescription();
        
    }

    public void ResetDescription()
    {
        this.itemImage.gameObject.SetActive(false);
        this.title.text = " ";
        this.describtion.text = " ";
    }

    public void SetDescription(Sprite sprite,string itemName, string itemDescription )
    {
        this.itemImage.gameObject.SetActive(true);
        this.itemImage.sprite = sprite;
        this.title.text = itemName;
        this.describtion.text = itemDescription;

    }
}
}

 