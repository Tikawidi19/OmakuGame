using System.Collections;
using System.Collections.Generic;
using inventory;
using inventory.Model;
using inventory.UI;
using UnityEngine;

public class coba : MonoBehaviour
{
     [SerializeField] private UIInventoryPage inventoryUI;
    [SerializeField] private InventorySO inventoryData;

    // [SerializeField] GameObject finishedCanvas;
    // [SerializeField] GameObject akhirCanvas;

    //[SerializeField] TMP_Text finishedText;
    

    private void Start() {
        inventoryUI.Show();
    }

    
}


