using System.Collections;
using System.Collections.Generic;
using inventory.Model;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private InventorySO inventoryData;
    public GameObject[] objectsToDisable;

    private itemC currentItem;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        itemC item = collision.GetComponent<itemC>();
        if (item != null)
        {
            int reminder = inventoryData.AddItem(item.InventoryItem, item.Quantity);
            if (reminder == 0)
            {
                currentItem = item; // Menyimpan referensi item saat ini
                currentItem.info.SetActive(true); // Memastikan info item tidak langsung ditampilkan
                currentItem.DestroyItem();
                PauseGame();
            } 
            else
            {
                item.Quantity = reminder;
            }
        }        
    }

    private void Update()
    {
        // Memeriksa apakah ada sentuhan pada layar
        if (currentItem != null && Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    ShowItemInfo();
                    break;
                }
            }
        }
    }

    private void ShowItemInfo()
    {
        currentItem.info.SetActive(false);
        PauseGame();
        currentItem = null; // Reset currentItem setelah menampilkan info
    }

    public void PauseGame()
    {
        foreach (GameObject obj in objectsToDisable)
        {
            obj.SetActive(false);
        }
        Debug.Log("Game Paused");
    }

    public void ResumeGame()
    {
        foreach (GameObject obj in objectsToDisable)
        {
            obj.SetActive(true);
        }
        Debug.Log("Game Resumed");
    }
}

