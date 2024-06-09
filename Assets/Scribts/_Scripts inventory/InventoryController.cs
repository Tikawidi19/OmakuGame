using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using inventory.UI;
using inventory.Model;

namespace inventory
{
    public class  InventoryController: MonoBehaviour
{
    [SerializeField] private UIInventoryPage inventoryUI;
    [SerializeField] private InventorySO inventoryData;
    public int inventorySize = 10;

    private void Start()
    {
        PrepareUI();
        // inventoryData.Initialize();
    }

    private void PrepareUI()
    {
        inventoryUI.InitializeInventoryUI(inventoryData.size);
        this.inventoryUI.OnDescriptionRequested += HandleDescriptionRequest;
        this.inventoryUI.OnItemActionRequested += HandleItemActionRequest;
    }

    private void HandleItemActionRequest(int itemIndex)
    {
        
    }

    private void HandleDescriptionRequest(int itemIndex)
    {
        InventoryItem inventoryItem = inventoryData.GetItemAt(itemIndex);
        if (inventoryItem.IsEmpty)
        {
            inventoryUI.ResetSelection();
            return;
        }
        itemSO item = inventoryItem.item;
        inventoryUI.UpdateDescription(itemIndex, item.ItemImage, item.name, item.Describtion);
    }

    
    public void Update() {
        
      // tombol();
        
    //    if (Input.GetKeyDown(KeyCode.I)){
            
            if (inventoryUI.isActiveAndEnabled == false)
            {
                //inventoryUI.Show();
                foreach (var item in inventoryData.GetCurrentInventoryState())
                {
                    inventoryUI.UpdateData(item.Key, item.Value.item.ItemImage, item.Value.quantity);
                }
            }
            // else{
            //      inventoryUI.Hide();
            // }
    //     }
    }

    // public void tombol()
    // {
    //     if(Input.GetMouseButtonDown(0))
    //         if (inventoryUI.isActiveAndEnabled == false)
    //         {
    //             inventoryUI.Show();
    //             foreach (var item in inventoryData.GetCurrentInventoryState())
    //             {
    //                 inventoryUI.UpdateData(item.Key, item.Value.item.ItemImage, item.Value.quantity);
    //             }
    //         }
    //         else{
    //             inventoryUI.Hide();
    //         }
    //     }
    }
}


